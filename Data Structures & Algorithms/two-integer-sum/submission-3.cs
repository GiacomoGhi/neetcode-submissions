

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexesByNum = [];
        foreach (var (i, num) in nums.Index())
        {
            var complement = target - num;
            if (indexesByNum.TryGetValue(complement, out var j))
            {
                return [j, i];
            }
            indexesByNum[num] = i;
        }

        return [];
    }
}
