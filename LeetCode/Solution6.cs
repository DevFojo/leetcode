using System.Text;

namespace LeetCode
{
    public class Solution6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
            {
                return s;
            }

            var rowStrings = new StringBuilder[numRows];
            for (var i = 0; i < numRows; i++)
            {
                rowStrings[i] = new StringBuilder();
            }

            var up = false;
            var row = 0;
            foreach (var c in s)
            {
                rowStrings[row].Append(c);
                up = row == numRows - 1 || row != 0 && up;
                row += up ? -1 : 1;
            }

            var sb = new StringBuilder();
            foreach (var rs in rowStrings)
            {
                sb.Append(rs);
            }

            return sb.ToString();
        }
    }
}