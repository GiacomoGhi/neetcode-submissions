/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        long s = 1;
        long e = (long)n;

        long mid;
        while (s <= e)
        {
            mid = (s + e) / 2;
            var res = guess((int)mid);
            if (res < 0)
            {
                e = mid - 1;
            }
            else if (res > 0)
            {
                s = mid + 1;
            }
            else
            {
                return (int)mid;
            }
        }

        return n;
    }
}