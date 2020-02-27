using System.Collections.Generic;

namespace CodeSignal
{
    public class HashMap
    {
        private long hashMap(string[] queryType, int[][] query)
        {
            var map = new Dictionary<int, long>();
            long output = 0;
            for (var i = 0; i < queryType.Length; i++)
            {
                var qt = queryType[i];
                switch (qt)
                {
                    case "insert":
                        insert(map, query[i][0], query[i][1]);
                        break;
                    case "get":
                        output += get(map, query[i][0]);
                        break;
                    case "addToKey":
                        map = addToKey(map, query[i][0]);
                        break;
                    case "addToValue":
                        map = addToValue(map, query[i][0]);
                        break;
                }
            }

            return output;
        }

        private Dictionary<int, long> addToValue(Dictionary<int, long> map, int i)
        {
            var newMap = new Dictionary<int, long>();
            foreach (var (k, v) in map)
            {
                newMap[k] = v + i;
            }

            return newMap;
        }

        private Dictionary<int, long> addToKey(Dictionary<int, long> map, int value)
        {
            var newMap = new Dictionary<int, long>();
            foreach (var (k, v) in map)
            {
                newMap[k + value] = v;
            }

            return newMap;
        }

        private long get(Dictionary<int, long> map, int i)
        {
            return map[i];
        }

        private void insert(Dictionary<int, long> map, int key, int value)
        {
            map[key] = value;
        }
    }
}