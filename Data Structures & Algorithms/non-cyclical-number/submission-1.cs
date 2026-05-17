public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = [];
        while (n != 1)
        {
            var res = 0;
            while (n > 0)
            {
                res += (n % 10) * (n % 10);
                n = n / 10;
            }

            if (seen.Contains(res))
            {
                return false;
            }
            seen.Add(res);
            n = res;
        }

        return true;
    }
}
