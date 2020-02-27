using System.Collections.Generic;

namespace LeetCode
{
    public class Solution637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var averages = new List<double>();
            if (root == null)
            {
                return averages;
            }

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                double sum = 0;
                var count = q.Count;
                for (var i = 0; i < count; i++)
                {
                    var c = q.Dequeue();
                    sum += c.val;
                    if (c.left != null)
                    {
                        q.Enqueue(c.left);
                    }

                    if (c.right != null)
                    {
                        q.Enqueue(c.right);
                    }
                }

                averages.Add(sum / count);
            }

            return averages;
        }
    }
}