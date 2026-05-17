public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0" || num2.Length == 0)
        {
            return "0";
        }

        var res = new int[num1.Length + num2.Length];
        for (int i = 1; i <= num1.Length; i++)
        {
            for (int j = 1; j <= num2.Length; j++)
            {
                var t = (num1[^i] - '0') * (num2[^j] - '0');
                res[^(i + j - 1)] += t;
                res[^(i + j)] += res[^(i + j - 1)] / 10;
                res[^(i + j - 1)] %= 10;
            }
        }

        int beg = 0;
        while (beg < res.Length && res[beg] == 0) {
            beg++;
        }

        string[] result = res.Skip(beg).Select(x => x.ToString()).ToArray();
        return string.Join("", result);
    }
}
