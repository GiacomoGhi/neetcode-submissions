public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if (piles.Length == h)
        {
            return piles.Max();
        }

        int s = 1;
        int e = piles.Max();
        int mid;
        int res = e;
        while (s <= e)
        {
            mid = (s + e) / 2;
            if (CompletedEating(mid))
            {
                res = mid;
                e = mid - 1;
            }
            else
            {
                s = mid + 1;
            }
        }

        return res;

        bool CompletedEating(int rate)
        {
            long hours = 0;
            foreach (var pile in piles)
            {
                hours += (long)Math.Ceiling((double)pile / rate);
                if (hours > h)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
