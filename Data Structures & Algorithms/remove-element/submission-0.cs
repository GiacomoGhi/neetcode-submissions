/*

 curr = 0;
 val = 1;
 nums = [2,3,4,3,4]

 i = 0;

 curr = 0;
 curr = 1;
 curr = 2;
 curr = 3;

 curr = 3

*/

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var curr = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[curr++] = nums[i];
            }
        }

        return curr;
    }
}