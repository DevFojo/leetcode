using System.Collections.Generic;

namespace LeetCode
{
    public class Solution1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            var charDict = new Dictionary<char, int>();
            foreach (var c in chars)
            {
                charDict[c] = charDict.ContainsKey(c) ? charDict[c] + 1 : 1;
            }

            var count = 0;
            foreach (var word in words)
            {
                var wordCharDict = new Dictionary<char, int>();
                foreach (var c in word)
                {
                    wordCharDict[c] = wordCharDict.ContainsKey(c) ? wordCharDict[c] + 1 : 1;
                }

                var charMatched = 0;
                foreach (var (c, i) in wordCharDict)
                {
                    if (charDict.ContainsKey(c) && i <= charDict[c])
                    {
                        charMatched += i;
                    }
                    else
                    {
                        charMatched = 0;
                        break;
                    }
                }

                count += charMatched;
            }

            return count;
        }
    }
}