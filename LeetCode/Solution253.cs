using System;

namespace LeetCode
{
    public class Solution253
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            var n = intervals.Length;
            if (n <= 0)
            {
                return 0;
            }

            var starts = new int[n];
            var ends = new int[n];
            for (var i = 0; i < n; i++)
            {
                starts[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }

            Array.Sort(starts);
            Array.Sort(ends);

            var a = 0;
            var b = 0;
            var rooms = 0;
            while (a < n)
            {
                if (starts[a] >= ends[b])
                {
                    rooms--;
                    b++;
                }

                a++;
                rooms++;
            }

            return rooms;
        }
    }
}