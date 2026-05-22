/*
    [
        [5,5,3],
        [2,3,6],
        [1,1,1],
    ]

    q = [1, 1, 1, 2, 3, 3, 5, 5, 6]



*/

public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        if (matrix[0].Length == 0)
        {
            return 0;
        }

        var q = new PriorityQueue<(int r, int c), int>(matrix.Length * matrix[0].Length);
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                q.Enqueue((i, j), matrix[i][j]);
            }
        }

        var max = 0;
        var visit = new Dictionary<(int r, int c), int>(matrix.Length * matrix[0].Length);
        while (q.Count > 0)
        {
            var (r, c) = q.Dequeue();
            var v = matrix[r][c];
            int[] res = 
            [ 
                max,
                1 + dfs(r + 1, c, v),
                1 + dfs(r - 1, c, v),
                1 + dfs(r, c - 1, v),
                1 + dfs(r, c + 1, v)
            ];

            max = res.Max();
        }

        return max;

        int dfs(int r, int c, int prev)
        {
            if (Math.Min(r, c) < 0
                || r == matrix.Length
                || c == matrix[0].Length
                || matrix[r][c] <= prev)
            {
                return 0;
            }
            if (visit.TryGetValue((r, c), out var cost))
            {
                return cost;
            }

            var v = matrix[r][c];
            int[] res = 
            [
                dfs(r + 1, c, v),
                dfs(r - 1, c, v),
                dfs(r, c - 1, v),
                dfs(r, c + 1, v)
            ];

            visit[(r, c)] = 1 + res.Max();
            return visit[(r, c)];
        }
    }
}
