public class Solution {
    public string foreignDictionary(string[] words) {
        Dictionary<char, List<char>> adj = [];
        foreach (var word in words) {
            foreach (var c in word) {
                if (!adj.ContainsKey(c)) adj[c] = new();
            }
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            var (c, n) = (words[i], words[(i + 1)]);
            if (c == n)
            {
                continue;
            }
            if (c.Length > n.Length && c.StartsWith(n))
            {
                return "";
            }

            var j = 0;
            while (j < Math.Min(c.Length, n.Length) && c[j] == n[j])
            {
                j++;
            }

            if (j < Math.Min(c.Length, n.Length))
            {
                adj[c[j]].Add(n[j]);
            }
        }

        var visit = new Dictionary<char, bool>();
        var result = new List<char>();
        foreach (var c in adj.Keys.OrderByDescending(x => x)) {
            if (dfs(c)) {
                return "";
            }
        }

        result.Reverse();
        var sb = new StringBuilder();
        foreach (var c in result) {
            sb.Append(c);
        }
        return sb.ToString();

        bool dfs(char n)
        {
            if (visit.ContainsKey(n))
            {
                return visit[n];
            }

            visit[n] = true;
            foreach (var nei in adj[n])
            {
                if (dfs(nei))
                {
                    return true;
                }
            }

            visit[n] = false;
            result.Add(n);
            return false;
        }
    }
}