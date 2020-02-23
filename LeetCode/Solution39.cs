using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var sums = new List<IList<int>>();
            if (candidates.Length == 0)
            {
                return sums;
            }

            var sub = new List<int>();
            Array.Sort(candidates);

            CombinationSum(sums, candidates, sub, target, 0);
            return sums;
        }

        private void CombinationSum(List<IList<int>> sums, int[] candidates, IList<int> sub, int target, int index)
        {
            if (target == 0)
            {
                sums.Add(new List<int>(sub));
                return;
            }

            for (var i = index; i < candidates.Length && target >= candidates[i]; ++i)
            {
                sub.Add(candidates[i]);
                CombinationSum(sums, candidates, sub, target - candidates[i], i);
                sub.Remove(sub.Last());
            }
        }
    }
}