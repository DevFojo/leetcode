using System.Collections.Generic;

namespace LeetCode
{
    public class Solution496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length < 1)
            {
                return nums1;
            }

            var nextMax = new Dictionary<int, int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                var j = i + 1;
                while (j < nums2.Length)
                {
                    if (nums2[j] > nums2[i])
                    {
                        nextMax[nums2[i]] = nums2[j];
                        break;
                    }

                    j++;
                }
            }

            var res = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; i++)
            {
                res[i] = !nextMax.ContainsKey(nums1[i]) ? -1 : nextMax[nums1[i]];
            }

            return res;
        }
    }
}