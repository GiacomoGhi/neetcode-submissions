/*
    [1  2  1] 0  4  2  6

    k = 3
    max = 6;
    res = [2, 2, 4, 4, 6]

*/

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        var res = new int[1 + nums.Length - k];
        for (int i = 0; i < res.Length; i++)
        {
            var max = int.MinValue;
            for (int j = i; j < i + k; j++)
            {
                max = Math.Max(nums[j], max);
            }
            res[i] = max;
        }

        return res;
    }
}
