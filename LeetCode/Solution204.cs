namespace LeetCode
{
    public class Solution204
    {
        public int CountPrimes(int n)
        {
            var isPrime = new bool[n];
            for (var i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            for (var i = 2; i * i < n; i++)
            {
                if (!isPrime[i])
                {
                    continue;
                }

                for (var j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }

            var count = 0;
            for (var i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}