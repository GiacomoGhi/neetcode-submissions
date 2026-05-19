/*
    [1  2  1] 0  4  2  6

    k = 3
    max = 6;
    res = [2, 2, 4, 4, 6]

*/

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        var res = new int[1 + nums.Length - k];
        var pq = new PriorityQueue<(int val, int ix), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < k; i++)
        {
            pq.Enqueue((nums[i], i), nums[i]);
        }
        res[0] = pq.Peek().val;

        for (int i = k; i < nums.Length; i++)
        {
            pq.Enqueue((nums[i], i), nums[i]);
            while (pq.Peek().ix <= i - k)
            {
                _ = pq.Dequeue();
            }
            res[i - k + 1] = pq.Peek().val;
        }

        return res;
    }
}
