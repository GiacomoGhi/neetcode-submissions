public class Solution {
    private HashSet<(int, int)> visited = [];

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0
                    || visited.Contains((i, j)))
                {
                    continue;
                }

                var prevVisited = visited.Count;
                Dfs(grid, i, j);

                var diff = visited.Count - prevVisited;
                maxArea = Math.Max(maxArea, diff);
            }
        }

        return maxArea;
    }

    private void Dfs(int[][] grid, int r, int c)
    {
        if (Math.Min(r, c) < 0
            || r == grid.Length
            || c >= grid[r].Length
            || grid[r][c] == 0
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
