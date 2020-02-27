using System.Collections.Generic;

namespace LeetCode
{
    public class Solution160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var a = headA;
            var b = headB;
            var setA = new HashSet<ListNode>();
            var setB = new HashSet<ListNode>();
            while (a != null && b != null)
            {
                setA.Add(a);
                setB.Add(b);
                if (setB.Contains(a))
                {
                    return a;
                }

                if (setA.Contains(b))
                {
                    return b;
                }

                a = a.next;
                b = b.next;
            }

            var c = a ?? b;

            while (c != null)
            {
                if (a == null && setA.Contains(c) || b == null && setB.Contains(c))
                {
                    return c;
                }

                c = c.next;
            }

            return null;
        }
    }
}