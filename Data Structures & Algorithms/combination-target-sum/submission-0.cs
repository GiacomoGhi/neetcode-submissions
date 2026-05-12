public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = [];
        
        var sortedNums = nums.Order().ToArray();

        dfs([], 0, 0);
        return res;

        void dfs(List<int> subsets, int sum, int i)
        {
            if (sum == target)
            {
                res.Add([.. subsets]);
                return;
            }

            if (i == sortedNums.Length)
            {
                return;
            }

            if (sum + sortedNums[i] > target)
            {
                return;
            }

            subsets.Add(sortedNums[i]);
            dfs(subsets, sum + sortedNums[i], i);

            subsets.RemoveAt(subsets.Count - 1);
            dfs(subsets, sum, i + 1);
        }
    }
}