public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> freq = [];
        foreach (var c in s)
        {
            if (!freq.ContainsKey(c))
            {
                freq[c] = 0;
            }
            freq[c]++;
        }

        foreach (var c in t)
        {
            if (!freq.TryGetValue(c, out var count))
            {
                return false;
            }
            count--;

            if (count == 0)
            {
                freq.Remove(c);
            }
            else
            {
                freq[c] = count;
            }
        }

        return freq.Count == 0;
    }
}
