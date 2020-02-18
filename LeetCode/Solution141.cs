using System.Collections.Generic;

namespace LeetCode
{
    public class Solution141
    {
        public bool HasCycle(ListNode head)
        {
            var visited = new HashSet<ListNode>();
            var curr = head;
            while (curr != null)
            {
                if (visited.Contains(curr))
                {
                    return true;
                }

                visited.Add(curr);
                curr = curr.next;
            }

            return false;
        }
    }
}