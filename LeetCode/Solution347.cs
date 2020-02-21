using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution347
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var d = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!d.ContainsKey(num))
                {
                    d.Add(num, 1);
                }
                else
                {
                    d[num]++;
                }
            }

            return d.OrderByDescending(n => n.Value).Take(k).Select(n => n.Key).ToList();
        }
    }
}