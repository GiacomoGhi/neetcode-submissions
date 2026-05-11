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
        long e = n;
        while (s <= e)
        {
            int mid = (int)((e + s) / 2);
            if (guess(mid) > 0)
            {
                s = mid + 1;
            }
            else if (guess(mid) < 0)
            {
                e = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}