using System.Collections.Generic;

namespace LeetCode
{
    public class Solution202
    {
        public bool IsHappy(int n)
        {
            var visited = new HashSet<int>();
            while (n != 1 && !visited.Contains(n))
            {
                visited.Add(n);
                n = Next(n);
            }

            return n == 1;
        }

        private int Next(int n)
        {
            var sum = 0;
            while (n >= 10)
            {
                sum += n % 10 * (n % 10);
                n /= 10;
            }

            return sum + n * n;
        }
    }
}