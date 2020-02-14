using System.Collections.Generic;

namespace CodeSignal
{
    public class IsCryptSolution
    {
        bool isCryptSolution(string[] crypt, char[][] solution)
        {
            var d = new Dictionary<char, int>();
            foreach (var ci in solution)
            {
                d[ci[0]] = ci[1] - '0';
            }

            var values = new int[crypt.Length];
            for (var i = 0; i < crypt.Length; i++)
            {
                var s = crypt[i];
                var l = 0;
                var n = 0;
                while (l < s.Length)
                {
                    var x = d[s[l]];
                    if (x == 0 && l == 0 && s.Length > 1)
                    {
                        return false;
                    }

                    n += x * pow(10, s.Length - 1 - l);
                    l++;
                }

                values[i] = n;
            }

            return values[0] + values[1] == values[2];
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