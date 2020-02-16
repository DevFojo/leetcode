using System.Collections.Generic;

namespace LeetCode
{
    public class Solution7
    {
        public int Reverse(int x)
        {
            var negative = x < 1;
            x = negative ? -x : x;

            var digitStack = new Stack<int>();
            while (x > 0)
            {
                digitStack.Push(x % 10);
                x /= 10;
            }

            var count = 0;
            var reverse = 0;
            while (digitStack.Count > 0)
            {
                var d = digitStack.Pop();
                var mult = Pow(10, count);
                if (d > int.MaxValue / mult || d == int.MaxValue / mult && reverse > int.MaxValue % mult)
                {
                    return 0;
                }

                reverse += d * mult;
                count++;
            }

            return negative ? -reverse : reverse;
        }

        private int Pow(int x, int y)
        {
            var n = 1;
            while (y > 0)
            {
                n *= x;
                y--;
            }

            return n;
        }
    }
}