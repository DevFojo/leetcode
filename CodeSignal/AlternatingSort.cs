namespace CodeSignal
{
    public class AlternatingSort
    {
        private bool alternatingSort(int[] a)
        {
            var b = new int[a.Length];
            for (var i = 0; i < b.Length; i++)
            {
                if (i % 2 == 0)
                {
                    b[i] = a[i / 2];
                }
                else
                {
                    b[i] = a[a.Length - (i + 1) / 2];
                }
            }

            for (var i = 0; i < b.Length - 1; i++)
            {
                if (b[i] >= b[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}