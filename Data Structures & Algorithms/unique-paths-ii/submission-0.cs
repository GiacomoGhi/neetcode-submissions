/*

    obstacleGrid = 
    [
           * 
        [0,0,0],
      * [0,0,0],
        [0,1,0]
    ]

    res = 
    [
        [3,2,1],
      c [1,1,1],
      p [0,0,1],
    ]

*/

public class Solution {
    public int UniquePathsWithObstacles(int[][] g) {
        var (r, c) = (g.Length, g[0].Length);
        if (c == 0)
        {
            return 0;
        }

        var prevRow = new int[c];
        prevRow[^1] = 1;
        for (int i = r - 1; i >= 0; i--)
        {
            var currRow = new int[c];
            currRow[^1] = g[i][^1] == 1 || prevRow[^1] == 0 ? 0 : 1;
            for (int j = c - 2; j >= 0; j--)
            {
                currRow[j] = g[i][j] == 0
                    ? currRow[j + 1] + prevRow[j]
                    : 0;
            }
            prevRow = currRow;
        }

        return prevRow[0];
    }
}