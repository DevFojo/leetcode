using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace CodeSignal
{
    public class Sudoku2
    {
        bool sudoku2(char[][] grid)
        {
            var subArray = new Dictionary<int, Dictionary<char, char>>();
            var rowMap = new Dictionary<int, Dictionary<char, char>>();
            var columnMap = new Dictionary<int, Dictionary<char, char>>();
            for (var i = 0; i < 9; i++)
            {
                if (!rowMap.ContainsKey(i))
                {
                    rowMap[i] = new Dictionary<char, char>();
                }

                for (var j = 0; j < 9; j++)
                {
                    if (!columnMap.ContainsKey(j))
                    {
                        columnMap[j] = new Dictionary<char, char>();
                    }

                    var subArrayId = getSubArrayId(i, j);
                    var c = grid[i][j];
                    if (c == '.')
                    {
                        continue;
                    }

                    if (!subArray.ContainsKey(subArrayId))
                    {
                        subArray[subArrayId] = new Dictionary<char, char>();
                    }

                    if (columnMap[j].ContainsKey(c) || rowMap[i].ContainsKey(c) || subArray[subArrayId].ContainsKey(c))
                    {
                        return false;
                    }


                    subArray[subArrayId].Add(c, c);
                    rowMap[i].Add(c, c);
                    columnMap[j].Add(c, c);
                }
            }

            return true;
        }

        int getSubArrayId(int i, int j)
        {
            if (i < 3 && j < 3)
                return 0;
            if (i < 3 && j < 6)
                return 1;
            if (i < 3 && j < 9)
                return 2;
            if (i < 6 && j < 3)
                return 3;
            if (i < 6 && j < 6)
                return 4;
            if (i < 6 && j < 9)
                return 5;
            if (i < 9 && j < 3)
                return 6;
            if (i < 9 && j < 6)
                return 7;
            if (i < 9 && j < 9)
                return 8;
            return -1;
        }
    }
}