using System;

namespace LeetCode
{
    public class Solution189
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Array.Reverse(nums, 0, nums.Length);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
    }
}