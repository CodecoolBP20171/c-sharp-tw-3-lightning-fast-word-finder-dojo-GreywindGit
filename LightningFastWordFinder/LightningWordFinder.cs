using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string cleanText = Regex.Replace(text, @"[^A-Za-z ]{1}", " ");
            string[] words = cleanText.Split(' ');
            List<int> wordLengths = words.Select(word => word.Length).ToList();
            int maxIndex = wordLengths.IndexOf(wordLengths.Max());
            return words[maxIndex];
        }
    }
}
