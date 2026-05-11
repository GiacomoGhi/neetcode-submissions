public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int s = 0, e = points.Length - 1;
        int pivot = e + 1;

        while (pivot != k)
        {
            pivot = Partition(points, s, e);
            if (pivot < k)
            {
                s = pivot + 1;
            }
            else if (pivot > k)
            {
                e = pivot - 1;
            }
        }

        return [.. points.Take(k)];

    }
    
    private int Partition(int[][] points, int s, int e)
    {
        int left = s;
        int pivot = e;
        int pivotDist = Euclidean(points[pivot]);

        for (int i = s; i < e; i++)
        { 
            if (Euclidean(points[i]) <= pivotDist)
            {
                (points[i], points[left]) = (points[left], points[i]);
                left++;
            }
        }

        (points[pivot], points[left]) = (points[left], points[pivot]);

        return left;
    }

    private int Euclidean(int[] point)
        => point[0] * point[0] + point[1] * point[1];
}
