public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = [];

        dfs([]);
        return res;

        void dfs(HashSet<int> used)
        {
            if (used.Count == nums.Length)
            {
                res.Add([.. used]);
                return;
            }

            foreach (var n in nums)
            {
                if (used.Contains(n))
                {
                    continue;
                }
                used.Add(n);
                dfs(used);
                used.Remove(n);
            }
        }
    }
}
