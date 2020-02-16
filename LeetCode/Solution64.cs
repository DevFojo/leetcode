using System;

namespace LeetCode
{
    public class Solution64
    {
        public int MinPathSum(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var dp = new int[m][];
            for (var i = 0; i < m; i++)
            {
                dp[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    dp[i][j] += grid[i][j];
                    if (i > 0 && j > 0)
                    {
                        dp[i][j] += Math.Min(dp[i - 1][j], dp[i][j - 1]);
                    }
                    else if (i > 0)
                    {
                        dp[i][j] += dp[i - 1][j];
                    }
                    else if (j > 0)
                    {
                        dp[i][j] += dp[i][j - 1];
                    }
                }
            }

            return dp[m - 1][n - 1];
        }
    }
}