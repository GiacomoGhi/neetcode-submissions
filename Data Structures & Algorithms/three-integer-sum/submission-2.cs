public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = [];

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var l = i + 1;
            var r = nums.Length - 1;
            while (l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];
                if (sum < 0)
                {
                    l++;
                }
                else if (sum > 0)
                {
                    r--;
                }
                else
                {
                    res.Add([nums[i], nums[l++], nums[r--]]);
                    while (l < r && nums[l] == nums[l - 1]) l++;
                }
            }
        }

        return res;
    }
}
