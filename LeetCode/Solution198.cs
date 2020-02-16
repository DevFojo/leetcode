using System;
using Xunit;

namespace LeetCode
{
    public class Solution198
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var dp = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        dp[i] = nums[i];
                        break;
                    case 1:
                        dp[i] = Math.Max(nums[i - 1], nums[i]);
                        break;
                    default:
                        dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
                        break;
                }
            }

            return dp[nums.Length - 1];
        }

        [Fact]
        public void Test()
        {
            Assert.True(true);
        }
    }
}