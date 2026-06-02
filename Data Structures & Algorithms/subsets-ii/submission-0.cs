public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = [];

        dfs(0, []);

        return res;

        void dfs(int i, List<int> curr)
        {
            if (i == nums.Length)
            {
                res.Add([.. curr]);
                return;
            }

            curr.Add(nums[i]);
            dfs(i + 1, curr);

            while (i + 1 < nums.Length
                   && nums[i + 1] == nums[i])
            {
                i++;
            }
            curr.RemoveAt(curr.Count - 1);
            dfs(i + 1, curr);
        }
    }
}
