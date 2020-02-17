using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution456
    {
        public bool Find132pattern(int[] nums)
        {
            var n = nums.Length;
            if (n <= 2)
            {
                return false;
            }

            var minAt = new int[n];
            for (var i = 0; i < n; i++)
            {
                minAt[i] = i == 0 ? nums[i] : Math.Min(nums[i], minAt[i - 1]);
            }

            var stack = new Stack<int>();
            for (var i = n - 1; i >= 0; i--)
            {
                var j = nums[i];
                while (stack.Count > 0 && stack.Peek() < j)
                {
                    var k = stack.Pop();
                    if (k > minAt[i])
                    {
                        return true;
                    }
                }

                stack.Push(j);
            }

            return false;
        }
    }
}