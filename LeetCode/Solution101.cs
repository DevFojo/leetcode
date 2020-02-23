namespace LeetCode
{
    public class Solution101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null || left.val != right.val)
            {
                return false;
            }

            return IsSymmetric(left.right, right.left) && IsSymmetric(left.left, right.right);
        }
    }
}