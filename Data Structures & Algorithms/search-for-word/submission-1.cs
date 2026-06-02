/*
    [
        ["A","B","C","E"],
        ["S","F","C","S"],
        ["A","D","E","E"]
    ]
*/

public class Solution {
    public bool Exist(char[][] board, string word) {
        if (board[0].Length == 0)
        {
            return false;
        }
        HashSet<(int r, int c)> visit = [];
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[r].Length; c++)
            {
                if (dfs(0, r, c))
                {
                    return true;
                }
            }
        }

        return false;

        bool dfs (int i, int r, int c)
        {
            if (i == word.Length)
            {
                return true;
            }

            if (Math.Min(r, c) < 0
                || r == board.Length
                || c == board[r].Length
                || word[i] != board[r][c]
                || visit.Contains((r, c)))
            {
                return false;
            }
            visit.Add((r, c));

            var res = dfs(i + 1, r + 1, c)
                    || dfs(i + 1, r - 1, c)
                    || dfs(i + 1, r, c - 1)
                    || dfs(i + 1, r, c + 1);
            visit.Remove((r, c));

            return res;
        }
    }
}
