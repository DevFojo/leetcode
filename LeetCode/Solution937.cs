using System.Collections.Generic;

namespace LeetCode
{
    public class Solution937
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var digitLogs = new List<string>();
            var letterLogs = new List<string>();
            foreach (var log in logs)
            {
                if (char.IsDigit(log[log.IndexOf(' ') + 1]))
                {
                    digitLogs.Add(log);
                }
                else
                {
                    letterLogs.Add(log);
                }
            }

            letterLogs.Sort((a, b) =>
            {
                var aSplit = a.Split(' ', 2);
                var bSplit = b.Split(' ', 2);

                var cmp = aSplit[1].CompareTo(bSplit[1]);
                return cmp != 0 ? cmp : aSplit[0].CompareTo(bSplit[0]);
            });

            letterLogs.AddRange(digitLogs);
            return letterLogs.ToArray();
        }
    }
}