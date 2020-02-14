namespace CodeSignal
{
    public class CountTinyPairs
    {
        int countTinyPairs(int[] a, int[] b, int k)
        {
            var tinyCount = 0;
            var n = a.Length;
            for (var i = 0; i < n; i++)
            {
                var j = n - 1 - i;
                var pow10 = getSize(b[j]) + 1;
                var xy = a[i] * pow(10, pow10) + b[j];
                if (xy < k)
                    tinyCount++;
            }

            return tinyCount;
        }

        int getSize(int i)
        {
            var n = 0;
            while (i > 10)
            {
                i /= 10;
                n++;
            }

            return n;
        }

        int pow(int x, int y)
        {
            var ans = 1;
            while (y > 0)
            {
                ans *= x;
                y--;
            }

            return ans;
        }
    }
}