using Newtonsoft.Json;

// ReSharper disable All

namespace LeetCode
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;


        public TreeNode(int x)
        {
            val = x;
        }

        public TreeNode AddLeft(TreeNode l)
        {
            left = l;
            return this;
        }

        public TreeNode AddLeft(int l)
        {
            return this.AddLeft(new TreeNode(l));
        }

        public TreeNode AddRight(TreeNode r)
        {
            right = r;
            return this;
        }

        public TreeNode AddRight(int r)
        {
            return this.AddRight(new TreeNode(r));
        }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}