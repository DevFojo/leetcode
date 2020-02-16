namespace LeetCode
{
    public class Solution9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var y = 0;
            var n = x;
            while (x >= 10)
            {
                y += x % 10;
                y *= 10;
                x /= 10;
            }

            if (x > 0)
            {
                y += x;
            }

            return y == n;
        }
    }
}