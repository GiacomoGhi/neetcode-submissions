/*
    s = "([{}])"

    stack = ""
*/

public class Solution {
    public bool IsValid(string s) {
        if (s.Length <= 1 || s.Length % 2 != 0)
        {
            return false;
        }

        var res = true;
        var bracketsMap = new Dictionary<char, char> {{'}', '{'}, {']', '['}, {')', '('}};
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (bracketsMap.ContainsKey(c))
            {
                if (stack.Count == 0
                    || stack.Pop() != bracketsMap[c])
                {
                    return false;
                }
                continue;
            }
            stack.Push(c);
        }

        return res && stack.Count == 0;
    }
}
