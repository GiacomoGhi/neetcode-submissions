public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        StringBuilder posInRow = new(n);
        for (int i = 0; i < n; i++)
        {
            posInRow.Append('.');
        }
        Dictionary<(int r, int c), int> covered = [];
        List<List<string>> res = [];

        dfs(0, []);

        return res;

        void dfs(int r, List<string> curr)
        {
            if (r == n)
            {
                if (curr.Count == n)
                {
                    res.Add([.. curr]);
                }
                return;
            }

            for (int c = 0; c < n; c++)
            {
                if (covered.ContainsKey((r, c)))
                {
                    continue;
                }

                // Cover posInRows
                for (int j = 0; j < n; j++)
                {
                    CoveredAdd(j, c);
                    CoveredAdd(r, j);
                    if (r - j >= 0 && c - j >= 0)
                    {
                        CoveredAdd(r - j, c - j);
                    }
                    if (r + j < n && c + j < n)
                    {
                        CoveredAdd(r + j, c + j);
                    }
                    if (r - j >= 0 && c + j < n)
                    {
                        CoveredAdd(r - j, c + j);
                    }
                    if (r + j < n && c - j >= 0)
                    {
                        CoveredAdd(r + j, c - j);
                    }
                }
                
                // Run dfs on next row
                posInRow[c] = 'Q';
                curr.Add(posInRow.ToString());
                posInRow[c] = '.';
                dfs(r + 1, curr);

                // Back track
                curr.RemoveAt(curr.Count - 1);
                for (int j = 0; j < n; j++)
                {
                    CoveredRemove(j, c);
                    CoveredRemove(r, j);
                    if (r - j >= 0 && c - j >= 0)
                    {
                        CoveredRemove(r - j, c - j);
                    }
                    if (r + j < n && c + j < n)
                    {
                        CoveredRemove(r + j, c + j);
                    }
                    if (r - j >= 0 && c + j < n)
                    {
                        CoveredRemove(r - j, c + j);
                    }
                    if (r + j < n && c - j >= 0)
                    {
                        CoveredRemove(r + j, c - j);
                    }
                }
            }

            void CoveredAdd(int r, int c)
            {
                covered[(r, c)] = 1 + covered.GetValueOrDefault((r, c));
            }

            void CoveredRemove(int r, int c)
            {
                if (!covered.ContainsKey((r, c)))
                {
                    return;
                }

                if (covered[(r, c)] == 1)
                {
                    covered.Remove((r, c));
                }
                else
                {
                    covered[(r, c)]--;
                }
            }
        }
    }
}
