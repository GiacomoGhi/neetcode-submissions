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
        HashSet<(int, int)> visited = [];
        List<(int, int)> rotted = [];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0
                    || visited.Contains((i, j)))
                {
                    continue;
                }

                if (!Dfs(grid, i, j, visited, rotted))
                {
                    return -1;
                }
            }
        }

        var oranges = visited.Count - rotted.Count();
        var minutes = 0;
        while (oranges > 0)
        {
            var rottedCount = rotted.Count;
            for (int i = 0; i < rottedCount; i++)
            {
                var (r, c) = rotted[i];
                foreach (var (dr, dc) in positions)
                {
                    var (nr, nc) = (r + dr, c + dc);
                    if (visited.Contains((nr, nc)) && grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        rotted.Add((nr, nc));
                        oranges--;
                    }
                }
            }
            minutes++;
        }

        return minutes;
    }
    
    private bool Dfs(
        int[][] grid, 
        int r, 
        int c, 
        HashSet<(int, int)> visited,
        List<(int, int)> rotted)
    {
        if (Math.Min(r, c) < 0
            || r == grid.Length
            || c == grid[0].Length
            || grid[r][c] == 0
            || visited.Contains((r, c)))
        {
            return false;
        }

        visited.Add((r, c));
        bool containsRotted = false;
        if (grid[r][c] == 2)
        {
            containsRotted = true;
            rotted.Add((r, c));
        }

        containsRotted |= Dfs(grid, r + 1, c, visited, rotted)
                        | Dfs(grid, r - 1, c, visited, rotted)
                        | Dfs(grid, r, c - 1, visited, rotted)
                        | Dfs(grid, r, c + 1, visited, rotted);

        return containsRotted;
    }
}
