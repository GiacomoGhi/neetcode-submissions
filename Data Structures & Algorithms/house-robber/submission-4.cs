public class Solution {
    public int Rob(int[] nums) {
        Dictionary<int, int> mem = new();
        return Dfs(0);

        int Dfs(int s)
        {
            if (s >= nums.Length)
            {
                return 0;
            }
            if (mem.TryGetValue(s, out var result))
            {
                return result;
            }

            mem[s] = Math.Max(nums[s] + Dfs(s + 2), Dfs(s + 1));
            return mem[s];
        }
    }
}
