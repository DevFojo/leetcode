using System;

namespace LeetCode
{
    public class Solution1229
    {
        public int[] ReplaceElements(int[] arr)
        {
            var res = new int[arr.Length];
            res[arr.Length - 1] = -1;

            for (var i = arr.Length - 2; i >= 0; i--)
            {
                res[i] = Math.Max(res[i + 1], arr[i+1]);
                
            }

            return res;
        }
    }
}