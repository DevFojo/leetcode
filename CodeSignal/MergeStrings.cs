using System.Text;

namespace CodeSignal
{
    public class MergeStrings
    {
        public string mergeStrings(string s1, string s2)
        {
            var s1i = 0;
            var s2i = 0;
            var sb = new StringBuilder();
            while (s1i < s1.Length || s2i < s2.Length)
            {
                if (s1i < s1.Length && s2i < s2.Length)
                {
                    sb.Append(s1[s1i] < s2[s2i] ? s1[s1i++] : s2[s2i++]);
                    continue;
                }

                while (s1i < s1.Length)
                {
                    sb.Append(s1[s1i++]);
                }

                while (s2i < s2.Length)
                {
                    sb.Append(s2[s2i++]);
                }
            }


            return sb.ToString();
        }
    }
}