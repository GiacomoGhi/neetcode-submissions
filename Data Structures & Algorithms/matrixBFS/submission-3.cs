public class Solution {
    private readonly (int, int)[] directions =
    [
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0),
    ];

    public int ShortestPath(int[][] grid) {
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<(int, int)>();

        visited.Add((0, 0));
        queue.Enqueue((0, 0));

        var length = 0;
        while (queue.Count > 0)
        {
            var ql = queue.Count;
            for (int i = 0; i < ql; i++)
            {
                var (r, c) = queue.Dequeue();
                if (r == grid.Length - 1 && c == grid[0].Length - 1)
                {
                    return length;
                }

                foreach (var (dr, dc) in directions)
                {
                    var (nr, nc) = (r + dr, c + dc);
                    if (Math.Min(nr, nc) < 0
                        || nr >= grid.Length
                        || nc >= grid[0].Length
                        || grid[nr][nc] == 1
                        || visited.Contains((nr, nc)))
                    {
                        continue;
                    }
                    visited.Add((nr, nc));
                    queue.Enqueue((nr, nc));
                }
            }
            length++;
        }

        return -1;
    }
}
