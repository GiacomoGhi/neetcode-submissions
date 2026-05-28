/*

*/

public class Solution {
    public int MaxProfit(int[] prices) {
        Dictionary<(int, bool), int> memo = [];
        
        return dfs(0, true);

        int dfs(int i, bool isBuying)
        {
            if (i >= prices.Length)
            {
                return 0;
            }
            var key = (i, isBuying);
            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (isBuying)
            {
                memo[key] = Math.Max(
                    dfs(i + 1, false) - prices[i],
                    dfs(i + 1, true));

                return memo[key];
            }

            // Can only sell
            memo[key] = Math.Max(
                dfs(i + 2, true) + prices[i],
                dfs(i + 1, false));
            
            return memo[key];
        }    
    }
}
