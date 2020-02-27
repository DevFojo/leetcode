using System.Collections.Generic;
using System.Linq;

namespace CodeSignal
{
    public class MeanGroups
    {
        private int[][] meanGroups(int[][] a)
        {
            var means = new Dictionary<double, List<int>>();

            for (var i = 0; i < a.Length; i++)
            {
                var avg = a[i].Average();
                if (!means.ContainsKey(avg))
                {
                    means.Add(avg, new List<int>());
                }

                means[avg].Add(i);
            }

            var result = new List<int[]>();
            var j = 0;
            foreach (var (_, value) in means)
            {
                result.Add(value.ToArray());
            }

            return result.ToArray();
        }
    }
}