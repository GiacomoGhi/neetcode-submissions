public class Solution {
    public int Search(int[] nums, int target) {
        int s = 0;
        int e = nums.Length - 1;
        int res = -1;

        while (s <= e)
        {
            var mid = (e + s) / 2;
            if (nums[mid] < target)
            {
                s = mid + 1;
            }
            else if (nums[mid] > target)
            {
                e = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return res;
    }
}
