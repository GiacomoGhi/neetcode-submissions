/*
   
*/

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if (cost.Length <= 1)
        {
            return 0;
        }
        if (cost.Length == 2)
        {
            return cost.Min();
        }

        var memo = new int[cost.Length];
        Array.Fill(memo, -1);
        return Math.Min(dfs(0), dfs(1));
        
        int dfs(int i)
        {
            if (i >= cost.Length)
            {
                return 0;
            }
            if (memo[i] != -1)
            {
                return memo[i];
            }

            memo[i] = cost[i] + Math.Min(dfs(i + 1), dfs(i + 2));

            return memo[i];
        }
    }
}
