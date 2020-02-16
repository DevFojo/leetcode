using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution819
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var bannedWords = banned.Select(s => s.ToLower()).ToDictionary(s => s);

            var words = paragraph.ToLower()
                .Split(new[] {' ', ',', '.', '!', '?', ';', '\''}, StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();
            var maxWord = words[0];
            var maxCount = 0;
            foreach (var word in words)
            {
                if (bannedWords.ContainsKey(word))
                {
                    continue;
                }

                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }

                wordsCount[word]++;
            }

            return maxWord;
        }
    }
}