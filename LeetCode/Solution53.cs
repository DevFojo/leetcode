using System;

namespace LeetCode
{
    public class Solution53
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var maxSum = nums[0];
            var currSum = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(currSum + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}