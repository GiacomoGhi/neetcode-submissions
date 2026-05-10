public class Solution {
    public int CalPoints(string[] operations) {
        var records = new List<int>(operations.Length);

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "C":
                    records.RemoveAt(records.Count - 1);
                    break;
                case "D":
                    records.Add(records.Last() * 2);
                    break;
                case "+":
                    records.Add(records[^1] + records[^2]);
                    break;
                default:
                    records.Add(int.Parse(operation));
                    break;
            }
        }

        return records.Sum();
    }
}