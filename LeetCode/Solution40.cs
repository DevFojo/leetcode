using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class Solution40
    {
        public Solution40(ITestOutputHelper o)
        {
            _o = o;
        }

        private readonly ITestOutputHelper _o;

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates == null || candidates.Length <= 0)
            {
                return result;
            }

            Array.Sort(candidates);
            CheckSum(candidates, result, new List<int>(), 0, target);
            return result;
        }

        private void CheckSum(int[] candidates, List<IList<int>> result, List<int> sub, int index, int target)
        {
            if (target == 0)
            {
                result.Add(new List<int>(sub));
                return;
            }

            if (target < 0 || index >= candidates.Length)
            {
                return;
            }

            for (var i = index; i < candidates.Length; i++)
            {
                if (i != index && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                if (candidates[i] > target)
                {
                    break;
                }

                sub.Add(candidates[i]);
                CheckSum(candidates, result, sub, i + 1, target - candidates[i]);
                sub.Remove(candidates[i]);
            }
        }

        [Fact]
        public void Test()
        {
            CombinationSum2(new[] {1, 2, 1, 4, 6, 3, 4}, 7);
        }
    }
}