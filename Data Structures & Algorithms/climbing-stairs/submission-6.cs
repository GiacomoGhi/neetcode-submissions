public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2)
        {
            return n;
        }

        int[] dp = [1, 2];
        int i = 3;
        while (i <= n)
        {
            var temp = dp[1];
            dp[1] = dp[0] + dp[1];
            dp[0] = temp;
            i++;
        }

        return dp[1];
    }

    // public int ClimbStairs(int n) {
    //     var cache = new Dictionary<int, int>(n);
    //     return MemoedClimbStairs(n, cache);
    // }

    // public int MemoedClimbStairs(int n, Dictionary<int, int> cache)
    // {
    //     if (n <= 2)
    //     {
    //         return n;
    //     }
    //     if (cache.TryGetValue(n, out var res))
    //     {
    //         return res;
    //     }

    //     cache[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
    //     return cache[n];
    // }
}
