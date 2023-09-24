using System;
using System.Collections.Generic;
using System.Text;

namespace Quest01
{
    class CharService : ICharable
    {
        readonly TechnicalService techService = new TechnicalService();
        public Dictionary<char, int> GetCharStatistics(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Срабатывание в GetCharStatistics");
                return null;
            }
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(charsCount.ContainsKey(text[i])))
                {
                    charsCount.Add(text[i], 0);
                }
                if (charsCount.ContainsKey(text[i]))
                {
                    charsCount[text[i]]++;
                }
            }
            return charsCount;
        }
    }
}
