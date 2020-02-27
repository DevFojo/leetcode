using System.Collections.Generic;

namespace LeetCode
{
    public class Solution205
    {
        public bool IsIsomorphic(string s, string t)
        {
            var sSet = new Dictionary<char, int>();
            var tSet = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (sSet.ContainsKey(s[i]) != tSet.ContainsKey(t[i]) ||
                    sSet.ContainsKey(s[i]) && tSet.ContainsKey(t[i]) && sSet[s[i]] != tSet[t[i]])
                {
                    return false;
                }

                sSet[s[i]] = i;
                tSet[t[i]] = i;
            }

            return true;
        }
    }
}