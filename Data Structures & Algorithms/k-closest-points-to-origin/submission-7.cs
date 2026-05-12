public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> minHeap = new(
            points.Select(p => (p, Euclidean(p))));

        int[][] res = new int[k][];
        for (int i = 0; i < k; i++)
        {
            res[i] = minHeap.Dequeue();
        }

        return res;
    }

    private int Euclidean(int[] point)
        => point[0] * point[0] + point[1] * point[1];
}
