public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue)
        {
            return 0;
        }

        List<int> digits = [];
        bool isNegative = x < 0;
        x = Math.Abs(x);
        while (x > 0)
        {
            digits.Add(x % 10);
            x = x / 10;
        }

        List<int> max = [];
        int tempMax = int.MaxValue;
        while (tempMax > 0)
        {
            max.Add(tempMax % 10);
            tempMax = tempMax / 10;
        }
        max.Reverse();

        if (digits.Count == max.Count)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] < max[i])
                {
                    break;
                }
                else if (digits[i] > max[i])
                {
                    return 0;
                }
            }
        }

        var res = 0;
        for (int i = 0; i < digits.Count; i++)
        {
            res *= 10;
            res += digits[i];
        }

        return isNegative ? res * -1 : res;
    }
}