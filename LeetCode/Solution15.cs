using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            var ans = new List<IList<int>>();
            if (nums.Length <= 2)
            {
                return ans;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }

                if (i != 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        ans.Add(new List<int> {nums[i], nums[j], nums[k]});
                        while (j < nums.Length - 1 && nums[j] == nums[j + 1]) j++;
                        while (k > 0 && nums[k] == nums[k - 1]) k--;
                        j++;
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            return ans;
        }
    }
}