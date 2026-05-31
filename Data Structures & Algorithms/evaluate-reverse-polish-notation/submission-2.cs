public class Solution {
    public int EvalRPN(string[] tokens) {
        HashSet<string> ops = ["+", "-", "/", "*"];
        Stack<int> stack = new();
        foreach (var t in tokens)
        {
            if (!ops.Contains(t))
            {
                stack.Push(int.Parse(t));
                continue;
            }

            var (n2, n1) = (stack.Pop(), stack.Pop());
            var res = t switch
            {
                "+" => n1 + n2,
                "-" => n1 - n2,
                "*" => n1 * n2,
                "/" => n1 / n2,
            };
            stack.Push(res);
        }
        return stack.Pop();
    }
}

/*
    ["4","13","5","/","+"]
    (4 + (13 / 5))

    consec = 1
    s = [+, /, 5, ]
*/
