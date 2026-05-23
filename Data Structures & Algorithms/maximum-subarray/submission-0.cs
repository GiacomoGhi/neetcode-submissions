/*
    [2,-3,4,-2,2,1,-1,4]

    max = 8
    prev = 8

    curr = 8
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        var max = int.MinValue;
        var prev = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var curr = 0;
            if (prev <= 0)
            {
                curr += nums[i];
            }
            else
            {
                curr = prev + nums[i];
            }

            prev = curr;
            max = Math.Max(max, curr);
        }

        return max;
    }
}
