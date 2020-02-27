namespace CodeSignal
{
    public class RotateImage
    {
        public int[][] rotateImage(int[][] a)
        {
            return flip(transpose(a));
        }

        private int[][] transpose(int[][] a)
        {
            for (var i = 0; i < a.Length; i++)
            for (var j = i; j < a[i].Length; j++)
            {
                var temp = a[i][j];
                a[i][j] = a[j][i];
                a[j][i] = temp;
            }

            return a;
        }

        private int[][] flip(int[][] a)
        {
            for (var i = 0; i < a.Length; i++)
            for (var j = 0; j < a[i].Length / 2; j++)
            {
                var n = a[i].Length - 1 - j;
                var temp = a[i][j];
                a[i][j] = a[i][n];
                a[i][n] = temp;
            }

            return a;
        }
    }
}