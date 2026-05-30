/*
    [5,1,2,3,4]

    s = 6
    m = 1
    e = 2

    [3,4,5,6,1,2]
    [1,2,3,4]
*/

public class Solution {
    public int Search(int[] nums, int target) {
        var s = 0;
        var e = nums.Length - 1;

        while (s <= e)
        {
            var mid = (e + s) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[s] == target)
            {
                return s;
            }
            if (nums[e] == target)
            {
                return e;
            }

            if ((nums[s] < nums[mid] && nums[s] < target && target < nums[mid])
                || (nums[s] > nums[mid] && nums[mid] > target))
            {
                s++;
                e = mid - 1;
            }
            else
            {
                s = mid + 1;
                e--;
            }
        }

        return -1;
    }
}
