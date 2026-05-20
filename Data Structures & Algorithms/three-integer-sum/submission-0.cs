public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = [];
        HashSet<(int, int, int)> triplets = [];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0
                        && !triplets.Contains((nums[i], nums[j], nums[k])))
                    {
                        triplets.Add((nums[i], nums[j], nums[k]));
                        res.Add([nums[i], nums[j], nums[k]]);
                    }
                }
            }        
        }

        return res;
    }
}
