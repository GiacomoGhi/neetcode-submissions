public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        if (k == points.Length)
        {
            return points;
        }

        PartialQuickSort(points, 0, points.Length - 1, k);
        
        return points[.. k];
    }

    private void PartialQuickSort(int[][] points, int s, int e, int k)
    {
        if (e - s + 1 == 1)
        {
            return;
        }

        var left = s;
        var pivotDistance = GetPointsDistanceFromOrigin(points[e][0], points[e][1]);

        for (int i = s; i <= e; i++)
        {
            if (GetPointsDistanceFromOrigin(points[i][0], points[i][1]) < pivotDistance)
            {
                (points[left], points[i]) = (points[i], points[left]);
                left++;
            }
        }

        (points[e], points[left]) = (points[left], points[e]);

        if (left == k) return;
        if (left < k)
            PartialQuickSort(points, left + 1, e, k);
        else
            PartialQuickSort(points, s, left - 1, k);

        static double GetPointsDistanceFromOrigin(int x, int y)
            => (x*x) + (y*y);
    }
}
