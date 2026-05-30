public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> ixs = [];
        for (int i = 0; i < nums.Length; i++)
        {
            ixs[nums[i]] = i;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (ixs.TryGetValue(target - nums[i], out var ix) && ix != i)
            {
                int[] res = [i, ix];
                return [.. res.Order()];
            }
        }

        return [];
    }
}
