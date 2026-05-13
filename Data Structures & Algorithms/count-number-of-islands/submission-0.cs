public class Solution {
    private HashSet<(int, int)> visited = [];

    public int NumIslands(char[][] grid) {
        int counter = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '0'
                    || visited.Contains((i, j)))
                {
                    continue;
                }
                
                counter++;
                this.Dfs(grid, i, j);
            }
        }

        return counter;
    }

    private void Dfs(char[][]grid, int r, int c)
    {
        if (Math.Min(r, c) < 0
            || r == grid.Length
            || c >= grid[r].Length
            || grid[r][c] == '0'
            || visited.Contains((r, c)))
        {
            return;
        }

        visited.Add((r, c));

        Dfs(grid, r + 1, c);
        Dfs(grid, r - 1, c);
        Dfs(grid, r, c - 1);
        Dfs(grid, r, c + 1);
    }
}
