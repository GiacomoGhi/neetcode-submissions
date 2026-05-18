/*
    n = 3
    x = ['(', '(']

    x = [')', ')']

    r = ['(', ')']
*/


public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> res = [];
        dfs(n, 0, 0, new StringBuilder(), res);
        return res;
    }

    private void dfs(int n, int o, int c, StringBuilder curr, List<string> res)
    {
        if (curr.Length == 2 * n)
        {
            res.Add(curr.ToString());
            return;
        }

        if (o < n)
        {
            curr.Append('(');
            dfs(n, o + 1, c, curr, res);
            curr.Length--;
        }

        if (c < o)
        {
            curr.Append(')');
            dfs(n, o, c + 1, curr, res);
            curr.Length--;
        }
    }
}
