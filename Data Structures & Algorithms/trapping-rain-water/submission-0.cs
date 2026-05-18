/*
    [0,2,0,3,1,0,1,3,2,1]

    [
        [0,0,0,1,0,0,0,1,0,0]
        [0,1,0,1,0,0,0,1,1,0]
        [0,1,0,1,1,0,1,1,1,1]
    ]
*/

public class Solution {
    public int Trap(int[] height) {
        Queue<(int, int)> queue = new();
        var (row, cols) = (height.Max(), height.Length);
        int[,] grid = new int[row, cols];
        for(int i = cols - 1; i >= 0; i--)
        {
            var n = height[i];
            for (var j = n - 1; j >= 0; j--)
            {
                grid[j, i] = 1;
                if (i + 1 < cols
                    && grid[j, i + 1] == 0)
                {
                    queue.Enqueue((j, i));
                }
            }
        }

        int total = 0;
        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();
            c++;

            int curr = 0;
            while (true)
            {
                if (c == cols)
                {
                    break;
                }
                else if (grid[r, c] == 1)
                {
                    total += curr;
                    break;
                }

                curr++;
                c++;
            }
        }

        return total;
    }
}
