using System.Collections.Generic;

namespace LeetCode
{
    public class Solution994
    {
        public int OrangesRotting(int[][] grid)
        {
            var r = grid.Length;
            var c = grid[0].Length;
            if (r <= 0)
            {
                return 0;
            }

            var rottenDepth = new Dictionary<int, int>();
            var fresh = new Dictionary<int, int>();
            var q = new Queue<int>();
            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                {
                    var id = i * c + j;
                    if (grid[i][j] == 2)
                    {
                        rottenDepth[id] = 0;
                        q.Enqueue(id);
                    }

                    if (grid[i][j] == 1)
                    {
                        fresh[id] = id;
                    }
                }
            }

            if (q.Count <= 0)
            {
                if (fresh.Count <= 0)
                {
                    return 0;
                }

                return -1;
            }

            var dir = new[] {new[] {0, -1}, new[] {-1, 0}, new[] {0, 1}, new[] {1, 0}};

            var totalDepth = 0;
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                var i = curr / c;
                var j = curr % c;
                foreach (var d in dir)
                {
                    var ni = i + d[0];
                    var nj = j + d[1];

                    if (ni >= 0 && ni < r && nj >= 0 && nj < c && grid[ni][nj] == 1)
                    {
                        var id = ni * c + nj;
                        grid[ni][nj] = 2;
                        fresh.Remove(id);
                        var depth = rottenDepth[curr] + 1;
                        rottenDepth.Add(id, depth);
                        q.Enqueue(id);
                        totalDepth = depth;
                    }
                }
            }

            if (fresh.Count > 0)
            {
                return -1;
            }

            return totalDepth;
        }
    }
}