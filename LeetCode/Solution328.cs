using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode
{
    public class Solution328
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public int[] ToArray()
            {
                var currentNode = this;
                var list = new List<int>();
                while (currentNode != null)
                {
                    list.Add(currentNode.val);
                    currentNode = currentNode.next;
                }

                return list.ToArray();
            }

            public static ListNode FromArray(int[] array)
            {
                var head = new ListNode();
                var node = head;
                foreach (var i in array)
                {
                    node.next = new ListNode(i);
                    node = node.next;
                }

                return head.next;
            }

            public void Print()
            {
                var arr = ToArray();
                for (var index = 0; index < arr.Length - 1; index++)
                {
                    Console.Write($"{arr[index]}->");
                }

                Console.Write(arr[^1]);
            }
        }

        public ListNode OddEvenList(ListNode head)
        {
            var currentNode = head;
            if (currentNode == null)
            {
                return null;
            }
            ListNode even = null;
            ListNode evenHead = null;         
            ListNode odd = null;
            ListNode oddHead = null;
            var last = new ListNode();
            var i = 1;
            while (currentNode != null)
            {
                if (i % 2 != 0)
                {
                    if (odd == null)
                    {
                        oddHead = currentNode;
                        odd = new ListNode();
                    }
                    odd.next = currentNode;
                    odd = odd.next;
                }
                else
                {
                    if (even == null)
                    {
                        evenHead = currentNode;
                        even = new ListNode();
                    }

                    even.next = currentNode;
                    even = even.next;
                }

                if (currentNode.next != null)
                {
                    last = currentNode;
                }

                currentNode = currentNode.next;
                i++;
            }

            last.next = null;
            odd.next = evenHead;
            return oddHead;
        }
        
    }
}
