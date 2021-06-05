namespace LeetCode
{
    public class Solution938
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return Count(root, low, high);
        }

        private int Count(TreeNode node, int low, int high)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.val < low)
            {
                return Count(node.right, low, high);
            }

            if (node.val > high)
            {
                return Count(node.left, low, high);
            }

            return node.val + Count(node.left, low, high) + Count(node.right, low, high);
        }
    }
}
