public class Solution {
    public int Rob(int[] nums) {
        Dictionary<(int, bool), int> mem = [];

        return dfs(0, false);

        int dfs(int i, bool fr)
        {
            if (i >= nums.Length)
            {
                return 0;
            }
            if (i == nums.Length - 1 && fr)
            {
                return 0;
            }
            if (mem.ContainsKey((i, fr)))
            {
                return mem[(i, fr)];
            }

            mem[(i, fr)] = Math.Max(
                nums[i] + dfs(i + 2, i == 0 || fr),
                dfs(i + 1, fr));
            return mem[(i, fr)];
        }
    }
}
