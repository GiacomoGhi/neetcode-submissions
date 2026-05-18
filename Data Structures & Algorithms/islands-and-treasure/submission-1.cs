/*
Input:
    [
        [L,L, L],
        [L,-1,L],
        [0,L, L]
    ]
*/

public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        List<(int, int)> tresures = [];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    tresures.Add((i, j));
                }
            }
        }

        foreach (var (r, c) in tresures)
        {
            dfs(grid, r - 1, c, 1);
            dfs(grid, r + 1, c, 1);
            dfs(grid, r, c - 1, 1);
            dfs(grid, r, c + 1, 1);
        }
    }

    public void dfs(int[][] grid, int r, int c, int steps)
    {
        if (Math.Min(r, c) < 0
            || r == grid.Length
            || c == grid[r].Length
            || grid[r][c] == -1
            || grid[r][c] <= steps)
        {
            return;
        }

        grid[r][c] = steps;

        steps++;
        dfs(grid, r, c - 1, steps);
        dfs(grid, r, c + 1, steps);
        dfs(grid, r + 1, c, steps);
        dfs(grid, r - 1, c, steps);
    }
}
