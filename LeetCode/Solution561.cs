using System;

namespace LeetCode
{
    public class Solution561
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var n = nums.Length;
            var sum = 0;
            for (var i = 0; i < n; i += 2)
            {
                if (i % 2 == 0)
                    sum += nums[i];
            }

            return sum;
        }
    }
}