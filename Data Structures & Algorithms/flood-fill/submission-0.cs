/*
    sr = 1
    sc = 1
    color = 2

    image = 
    [
        [2,2,2],
        [2,2,0],
        [2,0,1]
    ];


*/

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {        
        var original = image[sr][sc];
        Dfs(sr, sc);
        return image;

        void Dfs(int sr, int sc)
        {
            if (Math.Min(sr, sc) < 0
                || sr == image.Length
                || sc == image[0].Length
                || image[sr][sc] == color
                || image[sr][sc] != original)
            {
                return;
            }

            image[sr][sc] = color;
            
            Dfs(sr + 1, sc);
            Dfs(sr - 1, sc);
            Dfs(sr, sc - 1);
            Dfs(sr, sc + 1);
        }
    }
}