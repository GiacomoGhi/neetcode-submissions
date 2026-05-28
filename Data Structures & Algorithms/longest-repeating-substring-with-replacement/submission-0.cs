/*
    AAABABB

    max = 0
*/

public class Solution {
    public int CharacterReplacement(string s, int k) {
        var max = 0;
        var l = 0;
        var r = 0;
        var curr = 0;
        Dictionary<char, int> freq = [];
        while (r < s.Length)
        {            
            if (!freq.ContainsKey(s[r]))
            {
                freq[s[r]] = 0;
            }
            freq[s[r]]++;
            
            curr = r - l + 1;
            if (curr - freq.Values.Max() > k)
            {
                freq[s[l]]--;
                l++;
                curr--;
            }
            
            r++;

            max = Math.Max(max, curr);
        }

        return max;
    }
}