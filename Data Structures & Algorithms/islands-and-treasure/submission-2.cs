public class Solution {
    private readonly (int, int)[] dirs =
    [
        (1, 0),
        (-1, 0),
        (0, -1),
        (0, 1)
    ];

    public void islandsAndTreasure(int[][] grid) {
        Queue<(int, int)> queue = new();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        while (queue.Count > 0)
        {
            int ql = queue.Count;
            for (int i = 0; i < ql; i++)
            {
                var (r, c) = queue.Dequeue();
                foreach (var (dr, dc) in dirs)
                {
                    var (nr, nc) = (r + dr, c + dc);
                    if (nr < 0 
                        || nr == grid.Length
                        || nc < 0
                        || nc == grid[r].Length
                        || grid[nr][nc] != int.MaxValue)
                    {
                        continue;
                    }

                    grid[nr][nc] = grid[r][c] + 1;
                    queue.Enqueue((nr, nc));
                }
            }
        }
    }
}
