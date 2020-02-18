using System.Collections.Generic;

namespace LeetCode
{
    public class Solution20
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var parentheses = new Dictionary<char, bool>
            {
                {'(', false},
                {'{', false},
                {'[', false},
                {')', true},
                {'}', true},
                {']', true}
            };
            foreach (var c in s)
            {
                if (parentheses[c])
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var last = stack.Pop();
                    if (!closes(c, last))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        private bool closes(char c, char o)
        {
            return o == '[' && c == ']' ||
                   o == '{' && c == '}' ||
                   o == '(' && c == ')';
        }
    }
}