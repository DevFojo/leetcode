using System.Collections.Generic;

namespace CodeSignal
{
    public class IsListPalindrome
    {
        public bool isListPalindrome(ListNode<int> l)
        {
            var s = new Stack<int>();
            var c = l;
            while (c != null)
            {
                s.Push(c.value);
                c = c.next;
            }

            while (l != null && s.Count > 0)
            {
                if (l.value != s.Pop())
                {
                    return false;
                }

                l = l.next;
            }

            return true;
        }
    }
}