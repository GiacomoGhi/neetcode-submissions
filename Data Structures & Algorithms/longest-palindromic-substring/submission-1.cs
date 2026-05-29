public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length == 1)
        {
            return s;
        }
        StringBuilder res = new StringBuilder(s.Length);
        res.Append(s[0]);

        var sub = new StringBuilder(s.Length);
        for (int i = 0; i < s.Length; i++)
        {
            sub.Append(s[i]);
            for (var j = i + 1; j < s.Length; j++)
            {
                sub.Append(s[j]);
                int len = j - i + 1;
                int k = 0;
                for (k = 0; k < len; k++)
                {
                    if (sub[k] != sub[len - 1 - k])
                    {
                        break;
                    }
                }

                if (k == len && len > res.Length)
                {
                    res = new StringBuilder(s.Length);
                    res.Append(sub);
                }
            }
            sub.Clear();
        }

        return res.ToString();
    }
}