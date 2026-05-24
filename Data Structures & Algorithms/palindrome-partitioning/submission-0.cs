public class Solution {
    public List<List<string>> Partition(string text) {
        List<List<string>> res = [];
        
        dfs(0, 0, []);

        return res;

        void dfs(int s, int e, List<string> subs)
        {
            if (e == text.Length)
            {
                if (s == text.Length)
                {
                    res.Add([.. subs]);
                }
                return;
            }
            
            string sub = text.Substring(s, e - s + 1);
            bool isPalin = sub.SequenceEqual(sub.Reverse());
            
            if (isPalin)
            {
                subs.Add(sub);
                dfs(e + 1, e + 1, subs);
                subs.RemoveAt(subs.Count - 1);
            }
            
            dfs(s, e + 1, subs);
        }
    }
}