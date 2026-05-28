/*
    AAABABB

    max = 0
*/

public class Solution {
    public int CharacterReplacement(string s, int k) {
        var max = 0;
        var l = 0;
        var r = 0;
        Dictionary<char, int> freq = [];
        var maxf = 0;
        while (r < s.Length)
        {            
            freq[s[r]] = 1 + freq.GetValueOrDefault(s[r]);
            maxf = Math.Max(maxf, freq[s[r]]);
            
            if (r - l + 1 - maxf > k)
            {
                freq[s[l]]--;
                l++;
            }
            
            max = Math.Max(max, r - l + 1);
            r++;
        }

        return max;
    }
}