using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfWords
{
    public partial class mainWin : Form
    {
        private Core _core;
        private List<Button> _wordButtons;
        private List<Button> _tipButtons;
        private int _currentSymbolIndex = 1;

        public mainWin()
        {
            InitializeComponent();
            Init();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _core.Start(GetСomplexity());
        }

        private void RefresfLayout()
        {
            GenerateWordButtons();
            GenerateTipButtons();
        }

        private void GenerateWordButtons()
        {
            if (_core != null)
            {
                _wordButtons.Clear();

                var firstButton = GetButton(_core.First, Color.DarkSalmon);
                _wordButtons.Add(firstButton);

                for (int i = 0; i < _core.HiddedCount; i++)
                {
                    var hiddenButton = GetButton("?", Color.Black);
                    _wordButtons.Add(hiddenButton);
                }

                var lastButton = GetButton(_core.Last, Color.DarkSalmon);
                _wordButtons.Add(lastButton);

                workLayout.Controls.Clear();
                workLayout.Controls.AddRange(_wordButtons.ToArray());
            }
        }

        private void ResetHiddenButtons()
        {
            if (_wordButtons != null)
            {
                _currentSymbolIndex = 1;
                Invoke(() =>
                {
                    for (int i = 1; i < _wordButtons.Count - 1; i++)
                    {
                        _wordButtons[i].Text = @"?";
                        _wordButtons[i].BackColor = Color.Transparent;
                    }

                    for (int i = 0; i < _tipButtons.Count; i++)
                    {
                        _tipButtons[i].BackColor = Color.Transparent;
                    }
                });
            }
        }

        private void GenerateTipButtons()
        {
            if (_core != null)
            {
                _tipButtons.ToList().ForEach(x => x.Click -= OnTipClick);
                _tipButtons.Clear();

                var hiddenChars = _core.GetHidden();
                var fakeChars = Randomizer.RandomSymbols(hiddenChars.Length * 3);
                var randomOrderedTips = Randomizer.RandomOrder(hiddenChars.Concat(fakeChars).ToArray());

                foreach (var tip in randomOrderedTips)
                {
                    var tipButton = GetButton(tip, Color.Black);
                    tipButton.Click += OnTipClick;
                    _tipButtons.Add(tipButton);
                }

                tipsPanel.Controls.Clear();
                tipsPanel.Controls.AddRange(_tipButtons.ToArray());
            }
        }

        private void OnTipClick(object sender, EventArgs e)
        {
            var tipButton = sender as Button;
            if (tipButton != null)
            {
                _wordButtons[_currentSymbolIndex].Text = tipButton.Text;
                _wordButtons[_currentSymbolIndex].BackColor = Color.PaleVioletRed;
                _currentSymbolIndex++;
                tipButton.BackColor = Color.LightSeaGreen;
                if (_currentSymbolIndex > _core.HiddedCount)
                {
                    if (!_core.Check(_wordButtons.Skip(1)
                        .Take(_wordButtons.Count - 2)
                        .Select(x => x.Text.First())
                        .ToArray()))
                    {
                        ResetHiddenButtons();
                    }
                }
            }
        }

        private void Init()
        {
            _core = new Core();
            Task.Run(() => 
            {
                _core.Loaded += OnLoaded;
                _core.Ticked += OnTicked;
                _core.LevelUp += OnLevelUp;
                _core.Reseted += OnReseted;
                _core.GameOver += OnGameOver;
            });

            _wordButtons = new List<Button>();
            _tipButtons = new List<Button>();
        }

        private void OnGameOver(object sender, int e)
        {
            Invoke(() =>
            {
                MessageBox.Show($@"Level: {e}", @"Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lbl_score.Text = _core.Score.ToString();
                lbl_timeout.Text = _core.Timeout.ToString();
                btn_start.Enabled = true;
                ResetHiddenButtons();
            });
            
        }

        private void OnReseted(object sender, EventArgs e)
        {
            Invoke(() =>
            {
                RefresfLayout();
                lbl_score.Text = _core.Score.ToString();
                lbl_timeout.Text = _core.Timeout.ToString();
                ResetHiddenButtons();
            });
        }

        private void OnLevelUp(object sender, EventArgs e)
        {
            _currentSymbolIndex = 1;
            Invoke(() => lbl_cong.Visible = true);
            Disable();
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                Enable();
                Invoke(() =>
                {
                    lbl_cong.Visible = false;

                    lbl_score.Text = _core.Score.ToString();
                    lbl_timeout.Text = _core.Timeout.ToString();
                    RefresfLayout();
                    
                });
            });
        }

        private void OnTicked(object sender, int e)
        {
            Invoke(() =>
            {
                lbl_score.Text = _core.Score.ToString();
                lbl_timeout.Text = _core.Timeout.ToString();
            });
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Invoke(() =>
            {
                RefresfLayout();
                lbl_score.Text = _core.Score.ToString();
                lbl_timeout.Text = _core.Timeout.ToString();
                btn_start.Enabled = false;
            });
        }

        private Сomplexity GetСomplexity()
        {
            return rbtn_easy.Checked ? Сomplexity.Easy : rbtn_medium.Checked ? Сomplexity.Medium : Сomplexity.Hard;
        }

        private Button GetButton(string text, Color foreground)
        {
            return new Button
            {
                Text = text,
                ForeColor = foreground,
                Margin = new Padding(10),
                Height = 70,
                Width = 70,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 24)
            };
        }

        private void Invoke(Action action)
        {
            Invoke(new MethodInvoker(action.Invoke));
        }

        private void Enable()
        {
            Invoke(() =>
            {
                _core.Pause = false;
                grb_menu.Enabled = true;
                grb_word.Enabled = true;
                grb_tips.Enabled = true;
            });
        }

        private void Disable()
        {
            Invoke(() =>
            {
                _core.Pause = true;
                grb_menu.Enabled = false;
                grb_word.Enabled = false;
                grb_tips.Enabled = false;
            });
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            _core.Stop();
            _core.Start(GetСomplexity());
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            _core.Stop();
            Invoke(() =>
            {
                tipsPanel.Controls.Clear();
                workLayout.Controls.Clear();
                lbl_score.Text = _core.Score.ToString();
            });
        }
    }
}
