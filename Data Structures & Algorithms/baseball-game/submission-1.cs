public class Solution {
    public int CalPoints(string[] operations) {
        var records = new List<int>(operations.Length);

        var total = 0;
        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "C":
                    total -= records[^1]; 
                    records.RemoveAt(records.Count - 1);
                    break;
                case "D":
                    records.Add(records.Last() * 2);
                    total += records[^1];
                    break;
                case "+":
                    records.Add(records[^1] + records[^2]);
                    total += records[^1];
                    break;
                default:
                    records.Add(int.Parse(operation));
                    total += records[^1];
                    break;
            }
        }

        return total;
    }
}