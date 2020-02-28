namespace LeetCode
{
    public class Solution134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var currentFuel = 0;
            var totalFuel = 0;
            var index = 0;
            for (var i = 0; i < gas.Length; i++)
            {
                currentFuel += gas[i] - cost[i];
                totalFuel += currentFuel;
                if (currentFuel < 0)
                {
                    index = i + 1;
                    currentFuel = 0;
                }
            }

            return totalFuel >= 0 ? index : -1;
        }
    }
}