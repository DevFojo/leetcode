using System;
using System.Collections.Generic;

namespace CodeSignal
{
    public class FirstNotRepeatingCharacter
    {
        public char firstNotRepeatingCharacter(string s)
        {
            var m = new Dictionary<char, List<int>>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!m.ContainsKey(s[i]))
                {
                    m.Add(s[i], new List<int> {i});
                }
                else
                {
                    m[s[i]].Add(i);
                }
            }

            var minIndex = s.Length;
            foreach (var kvp in m)
            {
                if (kvp.Value.Count == 1)
                {
                    minIndex = Math.Min(minIndex, kvp.Value[0]);
                }
            }

            return minIndex >= s.Length ? '_' : s[minIndex];
        }
    }
}