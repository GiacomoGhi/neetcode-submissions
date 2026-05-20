public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        Dictionary<int, List<(int nei, int cost)>> adj = [];
        foreach (var t in times)
        {
            if (!adj.ContainsKey(t[0]))
            {
                adj[t[0]] = [];
            }

            adj[t[0]].Add((t[1], t[2]));
        }

        HashSet<int> visit = new(n);
        PriorityQueue<(int node, int cost), int> pq = new();

        pq.Enqueue((k, 0), 0);
        var maxTime = 0;
        while (pq.Count > 0 && visit.Count < n)
        {
            var (node, cost) = pq.Dequeue();
            if (visit.Contains(node))
            {
                continue;
            }
            visit.Add(node);
            maxTime = cost;

            if (!adj.TryGetValue(node, out var neis))
            {
                continue;
            }

            foreach (var (nei, ncost) in neis)
            {
                pq.Enqueue((nei, cost + ncost), cost + ncost);
            }
        }

        return visit.Count == n ? maxTime : -1;
    }
}