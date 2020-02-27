using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution155
    {
        public class MinStack
        {
            private readonly Stack<(int n, int min)> _stack;

            /**
             * initialize your data structure here.
             */
            public MinStack()
            {
                _stack = new Stack<(int n, int min)>();
            }

            public void Push(int x)
            {
                _stack.Push((x, _stack.Count <= 0 ? x : Math.Min(x, _stack.Peek().min)));
            }

            public void Pop()
            {
                if (_stack.Count > 0)
                {
                    _stack.Pop();
                }
            }

            public int Top()
            {
                return _stack.Count == 0 ? 0 : _stack.Peek().n;
            }

            public int GetMin()
            {
                return _stack.Count == 0 ? 0 : _stack.Peek().min;
            }
        }
    }
}