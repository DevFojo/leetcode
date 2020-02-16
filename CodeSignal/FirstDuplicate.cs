using System.Collections.Generic;

namespace CodeSignal
{
    public class FirstDuplicate
    {
        public int firstDuplicate(int[] a)
        {
            var m = new Dictionary<int, int>();
            for (var i = 0; i < a.Length; i++)
            {
                if (m.ContainsKey(a[i]))
                {
                    return a[i];
                }

                m[a[i]] = i;
            }

            return -1;
        }
    }
}