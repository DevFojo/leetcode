using System;

namespace LeetCode
{
    public class Solution213
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            var dp1 = new int[nums.Length];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                switch (i)
                {
                    case 0:
                        dp1[i] = nums[i];
                        break;
                    case 1:
                        dp1[i] = Math.Max(nums[i - 1], nums[i]);
                        break;
                    default:
                        dp1[i] = Math.Max(dp1[i - 2] + nums[i], dp1[i - 1]);
                        break;
                }
            }

            var dp2 = new int[nums.Length];
            for (var i = 1; i < nums.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        dp2[i] = nums[i];
                        break;
                    case 2:
                        dp2[i] = Math.Max(nums[i - 1], nums[i]);
                        break;
                    default:
                        dp2[i] = Math.Max(dp2[i - 2] + nums[i], dp2[i - 1]);
                        break;
                }
            }

            return Math.Max(dp1[dp1.Length - 2], dp2[dp2.Length - 1]);
        }
    }
}