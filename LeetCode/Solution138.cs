using System.Collections.Generic;
using Xunit;

namespace LeetCode
{
    public class Solution138
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            var visited = new Dictionary<Node, Node>();
            var newRoot = new Node(-1);
            var p = newRoot;
            var c = head;
            while (c != null)
            {
                p.next = GetNode(visited, c);
                if (c.random != null)
                {
                    p.next.random = GetNode(visited, c.random);
                }

                p = p.next;
                c = c.next;
            }

            return newRoot.next;
        }

        private Node GetNode(Dictionary<Node, Node> visited, Node node)
        {
            if (!visited.ContainsKey(node))
            {
                visited.Add(node, new Node(node.val));
            }

            return visited[node];
        }
    }
}