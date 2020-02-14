namespace CodeSignal
{
    public class RemoveKFromList
    {
        ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            var head = l;
            ListNode<int> previous = null;
            var current = head;
            while (current != null)
            {
                if (current.value == k)
                {
                    if (previous?.next == null)
                    {
                        head = current.next;
                        current = head;
                        continue;
                    }

                    previous.next = current.next;
                }

                previous = current;
                current = current.next;
            }

            return head;
        }
    }
}