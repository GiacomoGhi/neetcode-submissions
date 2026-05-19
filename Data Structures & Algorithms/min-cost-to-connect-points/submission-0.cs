public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        if (points.Length == 0)
        {
            return 0;
        }

        HashSet<(int, int)> visit = [];
        PriorityQueue<(int, int), int> pq = new();
        pq.Enqueue((points[0][0], points[0][1]), 0);
        var res = 0;

        while (visit.Count < points.Length)
        {
            pq.TryDequeue(out (int, int) point, out int dist);

            if (visit.Contains(point))
            {
                continue;
            }
            visit.Add(point);
            res += dist;
            foreach (var n in points)
            {
                if (visit.Contains((n[0], n[1])))
                {
                    continue;
                }
                pq.Enqueue((n[0], n[1]), CalcDist(point, n));
            }
        }

        return res;
    }

    private int CalcDist((int x, int y) i, int[] j)
        => Math.Abs(i.x - j[0]) + Math.Abs(i.y - j[1]);
}