using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWords
{
    public static class Randomizer
    {
        public static string Random(string[] words)
        {
            var random = new Random();
            var wordIndex = random.Next(0, words.Length - 1);
            return words[wordIndex];
        }

        public static string RandomSymbol()
        {
            var random = new Random();
            var symbols = Reader.Read("alphabet");
            var symbolIndex = random.Next(0, symbols.Length - 1);
            return symbols[symbolIndex];
        }

        public static string[] RandomSymbols(int count)
        {
            var random = new Random();
            var symbols = Reader.Read("alphabet");
            var randomStrings = new List<string>();
            for (int i = 0; i < count ; i++)
            {
                randomStrings.Add(symbols[random.Next(0, symbols.Length - 1)]);
            }
            return randomStrings.ToArray();
        }

        public static string[] RandomOrder(string[] strings)
        {
            var random = new Random();
            return strings.OrderBy(x => random.Next()).ToArray();   
        }
    }
}
