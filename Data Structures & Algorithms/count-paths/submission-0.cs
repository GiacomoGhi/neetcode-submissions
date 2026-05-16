public class Solution {
    public int UniquePaths(int m, int n) {
        if (n <= 0)
        {
            return 0;
        }

        var prevRow = new int[n];
        for (int i = m - 1; i >= 0; i--)
        {
            var currRow = new int[n];
            currRow[^1] = 1;
            for (int j = n - 2; j >= 0; j--)
            {
                currRow[j] = currRow[j + 1] + prevRow[j];
            }
            prevRow = currRow;
        }

        return prevRow[0];
    }
}
