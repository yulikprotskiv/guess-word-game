using System;
using System.Collections.Generic;
using System.Linq;
using Timer = System.Threading.Timer;

namespace GameOfWords
{
    public class Core
    {
        #region Const

        private const string FilenameEasy = "easy";
        private const string FilenameMedium = "medium";
        private const string FilenameHard = "hard";

        private const int TimeoutSeconds = 30;
        private const int BonusSeconds = 15;

        #endregion

        #region Fields

        private string[] _words;
        private Timer _timer;
        private string _currentWord;

        #endregion

        #region Properties

        public bool Pause { get; set; }
        public int Score { get; set; }
        public int Timeout { get; set; }
        public Сomplexity Сomplexity { get; set; }

        public string First { get; set; }
        public string Last { get; set; }
        public int HiddedCount { get; set; }

        #endregion

        #region Events

        public EventHandler Loaded;
        public EventHandler<int> GameOver;
        public EventHandler Reseted;
        public EventHandler LevelUp;
        public EventHandler<int> Ticked;

        #endregion

        #region Public

        public void Start(Сomplexity complexity)
        {
            Score = 0;
            Сomplexity = complexity;

            switch (complexity)
            {
                case Сomplexity.Easy:
                    _words = Reader.Read(FilenameEasy).Where(x => x.Length > 2).ToArray();
                    break;
                case Сomplexity.Medium:
                    _words = Reader.Read(FilenameMedium);
                    break;
                case Сomplexity.Hard:
                    _words = Reader.Read(FilenameHard);
                    break;
                default:
                    _words = new string[] {};
                    break;
            }

            SelectWord();

            Loaded.Invoke(this, new EventArgs());

            RefereshTimer(TimeoutSeconds);
        }

        public bool Check(char[] hidden)
        {
            if (hidden.Length < _currentWord.Length - 2) return false;

            for (int i = 1, j = 0; i < _currentWord.Length - 1; i++, j++)
            {
                if (_currentWord[i] != hidden[j]) return false;
            }
            Winning();

            return true;
        }

        public void Reset()
        {
            Pause = false;
            Score = 0;

            _timer?.Dispose();
            _timer = null;

            SelectWord();

            Reseted.Invoke(this, new EventArgs());

            RefereshTimer(TimeoutSeconds);
        }

        public string[] GetHidden()
        {
            var chars = new List<Char>();

            for (int i = 1; i < _currentWord.Length - 1; i++)
            {
                chars.Add(_currentWord[i]);
            }

            return chars.Select(x => new string(x, 1)).ToArray();
        }

        public void Stop()
        {
            _timer?.Dispose();
            _timer = null;

            Score = 0;
            Pause = false;
        }

        #endregion

        #region Private

        private void Winning()
        {
            Score++;
            SelectWord();
            LevelUp.Invoke(this, new EventArgs());
            RefereshTimer(Timeout + BonusSeconds);
        }

        private void SelectWord()
        {
            _currentWord = Randomizer.Random(_words);
            First = _currentWord.Substring(0, 1);
            Last = _currentWord.Substring(_currentWord.Length - 1, 1);
            HiddedCount = _currentWord.Length - 2;
        }

        private void RefereshTimer(int timeout)
        {
            _timer?.Dispose();
            Timeout = timeout;
            _timer = new Timer(GameOverCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void GameOverCallback(object state)
        {
            if(Pause) return;

            Ticked.Invoke(this, Timeout);

            if (Timeout > 0)
            {
                Timeout--;
                return;
            }

            _timer.Dispose();
            _timer = null;

            GameOver.Invoke(this, Score);
            Reset();
        }

        #endregion
    }
}
