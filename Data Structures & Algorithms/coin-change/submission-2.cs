public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if (amount == 0)
        {
            return 0;
        }
        Dictionary<int, int> mem = [];
        var res = dfs(amount);

        return res == int.MaxValue ? -1 : res;

        int dfs(int curr)
        {
            if (curr == 0)
            {
                return 0;
            }
            if (mem.ContainsKey(curr))
            {
                return mem[curr];
            }

            int res = int.MaxValue;
            foreach (var c in coins)
            {
                if (curr - c >= 0)
                {
                    int result = dfs(curr - c);
                    if (result != int.MaxValue)
                    {
                        res = Math.Min(res, result + 1);
                    }
                }
            }

            mem[curr] = res;
            return res;
        }
    }
}
