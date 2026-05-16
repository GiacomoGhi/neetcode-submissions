public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if (text2.Length == 0)
        {
            return 0;
        }

        Dictionary<(int, int), int> mem = [];
        return dfs(0, 0);
        
        int dfs (int s1, int s2)
        {
            if (s1 >= text1.Length
                || s2 >= text2.Length)
            {
                return 0;
            }
            if (mem.TryGetValue((s1, s2), out var res))
            {
                return res;
            }

            if (text1[s1] == text2[s2])
            {
                res = 1 + dfs(s1 + 1, s2 + 1);
            }
            else
            {
                res = Math.Max(dfs(s1 + 1, s2), dfs(s1, s2 + 1));
            }

            mem[(s1, s2)] = res;
            return res;
        }
    }
}
