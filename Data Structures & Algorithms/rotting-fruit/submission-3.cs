/*
    f = 
    [
        [1,1,0],
        [0,1,1],
        [0,1,2]
    ];
*/

public class Solution {
    private readonly (int, int)[] positions =
    [
        (1, 0),
        (-1, 0),
        (0, -1),
        (0, 1),
    ];

    public int OrangesRotting(int[][] grid) {
        Queue<(int, int)> queue = [];
        var fresh = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                var orange = grid[i][j];
                if (orange == 1)
                {
                    fresh++;
                }
                else if (orange == 2)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        var time = 0;
        while (queue.Count > 0 && fresh > 0)
        {
            var qCount = queue.Count;
            for (int i = 0; i < qCount; i++)
            {
                var (r, c) = queue.Dequeue();
                foreach (var (dr, dc) in positions)
                {
                    var (nr, nc) = (dr + r, dc + c);
                    if (Math.Min(nr, nc) < 0
                        || nr == grid.Length
                        || nc == grid[0].Length
                        || grid[nr][nc] == 2
                        || grid[nr][nc] == 0)
                    {
                        continue;
                    }

                    grid[nr][nc] = 2;
                    queue.Enqueue((nr, nc));
                    fresh--;
                }
            }

            time++;
        }

        return fresh == 0 ? time : -1;
    }
}
