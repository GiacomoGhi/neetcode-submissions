public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = [];
        foreach (var s in strs)
        {
            var chars = new char[26];
            foreach (var c in s)
            {
                chars[c - 'a']++;
            }
            var key = string.Join(",", chars);
            if (!res.ContainsKey(key))
            {
                res[key] = [];
            }
            res[key].Add(s);
        }

        return res.Values.ToList();
    }
}
