using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length <= 0)
            {
                return null;
            }

            var heap = new MinHeap();

            foreach (var root in lists)
            {
                var c = root;
                while (c != null)
                {
                    heap.Push(c);
                    c = c.next;
                }
            }

            var fakeRoot = new ListNode(-1);
            var curr = fakeRoot;

            while (!heap.IsEmpty())
            {
                curr.next = heap.Pop();
                curr = curr.next;
            }

            return fakeRoot.next;
        }

        public class MinHeap
        {
            private readonly SortedDictionary<int, Queue<ListNode>> _store;

            public MinHeap()
            {
                _store = new SortedDictionary<int, Queue<ListNode>>();
            }

            public bool IsEmpty()
            {
                return _store.Count <= 0;
            }

            public void Push(ListNode node)
            {
                if (!_store.ContainsKey(node.val))
                {
                    _store[node.val] = new Queue<ListNode>();
                }

                _store[node.val].Enqueue(node);
            }

            public ListNode Pop()
            {
                if (IsEmpty())
                {
                    return null;
                }

                var key = _store.Keys.Min();
                var value = _store[key];
                var node = value.Dequeue();
                if (value.Count <= 0)
                {
                    _store.Remove(key);
                }

                return node;
            }
        }
    }
}