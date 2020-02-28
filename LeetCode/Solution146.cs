using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution146
    {
        public class LRUCache
        {
            private readonly Dictionary<int, int> _cache;
            private readonly int _capacity;
            private readonly LinkedList<int> _keys;

            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _cache = new Dictionary<int, int>();
                _keys = new LinkedList<int>();
            }

            public int Get(int key)
            {
                if (!_cache.ContainsKey(key))
                {
                    return -1;
                }

                _keys.Remove(key);
                _keys.AddFirst(key);
                return _cache[key];
            }

            public void Put(int key, int value)
            {
                if (_cache.ContainsKey(key))
                {
                    _keys.Remove(key);
                }
                else
                {
                    if (_keys.Count == _capacity)
                    {
                        var lastUsed = _keys.Last();
                        _cache.Remove(lastUsed);
                        _keys.RemoveLast();
                    }
                }

                _cache[key] = value;
                _keys.AddFirst(key);
            }
        }
    }
}