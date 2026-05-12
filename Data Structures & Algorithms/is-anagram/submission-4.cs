public class Solution {
    public bool IsAnagram(string s, string t) {
        var charsCounts = s
            .GroupBy(c => c)
            .ToDictionary(
                group => group.Key,
                group => group.Count());

        foreach (var c in t)
        {
            if (!charsCounts.TryGetValue(c, out var count))
            {
                return false;
            }

            if (count == 1)
            {
                charsCounts.Remove(c);
            }
            else
            {
                charsCounts[c] = --count;
            }
        }

        return charsCounts.Count == 0;
    }
}
