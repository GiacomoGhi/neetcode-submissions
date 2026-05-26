public class Solution {
    public int LengthOfLongestSubstring(string str) {
        if ((str ?? "").Length <= 1)
        {
            return str.Length;
        }

        int max = 0;
        var seen = new int[128];
        Array.Fill(seen, -1);
        var s = 0;
        var e = 0;
        foreach (var c in str)
        {
            if (seen[c] != -1)
            {
                s = Math.Max(s, seen[c] + 1);
            }
            seen[c] = e;
            e++;

            max = Math.Max(max, e - s);

        }

        return max;
    }
}
/*
    "zxyzxyz"

    seen = z
    max = 3
*/