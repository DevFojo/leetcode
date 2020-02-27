namespace LeetCode
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            var n = 0;
            var previousInt = int.MaxValue;
            foreach (var c in s)
            {
                var currentInt = getInt(c);
                if (currentInt > previousInt)
                {
                    n += -previousInt + currentInt - previousInt;
                }
                else
                {
                    n += currentInt;
                }

                previousInt = currentInt;
            }

            return n;
        }

        private int getInt(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }

            return 0;
        }
    }
}