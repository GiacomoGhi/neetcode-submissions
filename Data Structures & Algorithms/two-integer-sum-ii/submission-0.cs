public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var (l, r) = (0, numbers.Length - 1);
        while (l <  r)
        {
            var sum = numbers[l] + numbers[r];
            if (sum > target)
            {
                r--;
            }
            else if (sum < target)
            {
                l++;
            }
            else
            {
                return [++l, ++r];
            }
        }
        return [];
    }
}
