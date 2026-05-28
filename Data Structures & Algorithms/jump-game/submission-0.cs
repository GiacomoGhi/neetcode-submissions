public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 1)
        {
            return true;
        }

        var s = nums.Length - 1;
        var res = false;
        while (s > 0)
        {
            res = false;

            var i = 0;
            while (s > 0 && !res)
            {
                res = nums[--s] >= ++i;
            }
        }

        return res;
    }
}
/*
    [1,2,0,1,0]

    s = 3;
    res = false

    i = 0
*/