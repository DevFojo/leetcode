namespace LeetCode
{
    public class Solution21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var rootNode = new ListNode(-1);
            var currentNode = rootNode;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    currentNode.next = l1;
                    l1 = l1.next;
                }

                else
                {
                    currentNode.next = l2;
                    l2 = l2.next;
                }

                currentNode = currentNode.next;
            }

            currentNode.next = l1 ?? l2;
            return rootNode.next;
        }
    }
}