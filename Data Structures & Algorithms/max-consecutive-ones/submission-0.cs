public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, temp = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                temp++;
                if (temp > max)
                {
                    max = temp;
                }

                continue;
            }
            
            temp = 0;
        }

        return max;
    }
}