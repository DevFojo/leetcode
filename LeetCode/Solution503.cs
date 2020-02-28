using System.Collections.Generic;

namespace LeetCode
{
    public class Solution503
    {
        public int[] NextGreaterElements(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return nums;
            }

            var res = new int[nums.Length];
            var stack = new Stack<int>();

            for (var i = 2 * nums.Length - 1; i >= 0; i--)
            {
                var index = i % nums.Length;
                while (stack.Count > 0 && nums[stack.Peek()] <= nums[index])
                {
                    stack.Pop();
                }

                res[index] = stack.Count > 0 ? nums[stack.Peek()] : -1;
                stack.Push(index);
            }


            return res;
        }
    }
}