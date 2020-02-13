using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class Solution18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var ans = new List<IList<int>>();
            if (nums.Length < 4)
            {
                return ans;
            }

            Array.Sort(nums);

            for (var a = 0; a < nums.Length - 3; a++)
            {
                for (var b = 1; b < nums.Length - 2; b++)
                {
                    var midTarget = target - nums[a] - nums[b];
                    var c = b + 1;
                    var d = nums.Length - 1;
                    while (c < d)
                    {
                        var sum = midTarget - nums[c] - nums[d];
                        if (sum == 0)
                        {
                            ans.Add(new List<int> {nums[a], nums[b], nums[c], nums[d]});
                            while (c < d && nums[c] == nums[c + 1]) c++;
                            while (c < d && nums[d] == nums[d - 1]) d--;
                            c++;
                            d--;
                        }
                        else if (sum < 0)
                        {
                            c++;
                        }
                        else
                        {
                            d--;
                        }
                    }
                }
            }

            return ans;
        }

        private readonly ITestOutputHelper _o;

        public Solution18(ITestOutputHelper o)
        {
            _o = o;
        }

        [Fact]
        public void Test()
        {
            _o.WriteLine(JsonConvert.SerializeObject(FourSum(new[] {1, 0, -1, 0, -2, 2}, 0)));
        }
    }
}