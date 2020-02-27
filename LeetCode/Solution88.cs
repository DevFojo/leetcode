namespace LeetCode
{
    public class Solution88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var arr = new int[m + n];
            var i = 0;
            var j = 0;
            while (i < m || j < n)
            {
                if (nums1[i] == 0)
                {
                    i++;
                    continue;
                }

                if (nums2[j] == 0)
                {
                    j++;
                    continue;
                }

                if (j == n)
                {
                    arr[i + j - 1] = nums1[i++];
                    continue;
                }

                if (i == m)
                {
                    arr[i + j - 1] = nums2[j++];
                    continue;
                }

                arr[i + j] = nums1[i] <= nums2[j] ? nums1[i++] : nums2[j++];
            }
        }
    }
}