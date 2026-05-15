public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length <= 2)
        {
            return nums.Max();
        }

        var (num1, num2) = (0, 0);

        foreach (var num in nums)
        {
            var t = Math.Max(num + num1, num2);
            num1 = num2;
            num2 = t;
        }

        return num2;
    }
}
