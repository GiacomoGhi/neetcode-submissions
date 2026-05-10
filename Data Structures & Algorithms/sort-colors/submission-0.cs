public class Solution {
    public void SortColors(int[] nums) {
        int[] counts = [0, 0, 0];

        foreach (var num in nums)
        {
            counts[num]++;
        }

        int i = 0;
        for (int j = 0; j < counts.Length; j++)
        {
            for (int k = 0; k < counts[j]; k++)
            {
                nums[i] = j;
                i++;
            }
        }
    }
}