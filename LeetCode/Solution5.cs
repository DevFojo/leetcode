namespace LeetCode
{
    public class Solution5
    {
        //TODO: can be further optimized
        public string LongestPalindrome(string s)
        {
            var maxLength = 0;
            var maxPalindrome = "";
            var n = s.Length;

            for (var i = 0; i < n; ++i)
            for (var j = i; j < n; j++)
            {
                var l = j - i + 1;
                if (l <= maxLength)
                {
                    continue;
                }

                var sub = s.Substring(i, l);
                if (!IsPalindrome(sub))
                {
                    continue;
                }

                maxLength = l;
                maxPalindrome = sub;
            }

            return maxPalindrome;
        }

        private bool IsPalindrome(string s)
        {
            for (var i = 0; i < (s.Length + 1) / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}