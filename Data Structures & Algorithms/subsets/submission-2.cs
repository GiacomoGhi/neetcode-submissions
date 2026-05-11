/**

    num = [1, 2, 3, 4]
    
    i = 3
    j = 4

    res = 
    [
        [],
        [1]
        [1, 2]
        [1, 2, 3]
        [1, 3]
        [1, 2, 3, 4]
        [1, 4]
        [2]
        [2, 3]
        [2, 3, 4]
        [2, 4]
        [3]
        [3, 4]
    ]

*/

public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = [];

        List<int> subset = [];

        dfs(0);
        return res;

        void dfs(int i)
        {
            if (i >= nums.Length)
            {
                res.Add([.. subset]);
                return;
            }

            subset.Add(nums[i]);
            dfs(i + 1);

            subset.RemoveAt(subset.Count - 1);
            dfs(i + 1);
        }
    }
}
