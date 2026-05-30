public class Solution {
    public string LongestPalindrome(string s) {
        var resIx = 0;
        var resLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var l = i;
            var r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l + 1 > resLen)
                {
                    resLen = r - l + 1;
                    resIx = l;
                }
                l--;
                r++;
            }
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l + 1 > resLen)
                {
                    resLen = r - l + 1;
                    resIx = l;
                }
                l--;
                r++;
            }
        }

        return s.Substring(resIx, resLen);
    }
}
