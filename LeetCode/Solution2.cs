namespace LeetCode
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sumList = new ListNode(0);
            var d = sumList;
            var sum = 0;
            var c1 = l1;
            var c2 = l2;
            while (c1 != null || c2 != null)
            {
                sum /= 10;
                if (c1 != null)
                {
                    sum += c1.val;
                    c1 = c1.next;
                }

                if (c2 != null)
                {
                    sum += c2.val;
                    c2 = c2.next;
                }

                d.next = new ListNode(sum % 10);
                d = d.next;
            }

            if (sum >= 10)
            {
                d.next = new ListNode(sum / 10);
            }

            return sumList.next;
        }
    }
}