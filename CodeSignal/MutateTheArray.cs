namespace CodeSignal
{
    public class MutateTheArray
    {
        private int[] mutateTheArray(int n, int[] a)
        {
            var b = new int[a.Length];
            for (var i = 0; i < a.Length; i++)
            {
                var x = 0;
                if (i > 0)
                {
                    x = a[i - 1];
                }

                var y = 0;
                if (i < a.Length - 1)
                {
                    y = a[i + 1];
                }

                b[i] = x + a[i] + y;
            }

            return b;
        }
    }
}