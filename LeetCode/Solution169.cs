using System.Collections.Generic;

namespace LeetCode
{
    public class Solution169
    {
        public int MajorityElement(int[] nums)
        {
            var numCount = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                numCount[num] = numCount.ContainsKey(num) ? numCount[num] + 1 : 1;
            }

            foreach (var (key, value) in numCount)
            {
                if (value > nums.Length / 2)
                {
                    return key;
                }
            }

            return -1;
        }
    }
}