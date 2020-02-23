using System.Collections.Generic;

namespace LeetCode
{
    public class Solution139
    {
        public bool WordBreak2(string s, IList<string> wordDict)
        {
            if (wordDict.Count <= 0)
            {
                return false;
            }

            var d = new HashSet<string>(wordDict);
            var isWordBreak = new bool[s.Length + 1];
            isWordBreak[0] = true;
            for (var i = 0; i <= s.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (!isWordBreak[j])
                    {
                        continue;
                    }

                    var sub = s.Substring(j, i - j);
                    if (!d.Contains(sub))
                    {
                        continue;
                    }

                    isWordBreak[i] = true;
                    break;
                }
            }

            return isWordBreak[s.Length];
        }

        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (wordDict.Count <= 0)
            {
                return false;
            }

            var set = new HashSet<string>(wordDict);
            var q = new Queue<int>();
            q.Enqueue(0);
            var visited = new bool[s.Length];
            while (q.Count > 0)
            {
                var i = q.Dequeue();
                if (visited[i])
                {
                    continue;
                }

                for (var j = 1; j <= s.Length - i; j++)
                {
                    if (!set.Contains(s.Substring(i, j)))
                    {
                        continue;
                    }

                    var e = i + j;
                    if (e == s.Length)
                    {
                        return true;
                    }

                    q.Enqueue(e);
                }

                visited[i] = true;
            }

            return false;
        }
    }
}