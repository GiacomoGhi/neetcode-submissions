/*
    [
        [1,3],
        [1,5],
        [6,7]
    ]

    c = [1, 3]
    |---| |---| (end < start) -> change c to next
    
    |---|
        |---| (end == start) -> updates c end to next end

    |---|
      |----| (end > start) -> updates c end with between c end and next end
    |-------| 
      |---|  
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        var sorted = intervals
            .OrderBy(interval => interval[0])
            .ToArray();

        List<int[]> merged = new(sorted.Length);
        var curr = sorted[0];
        for (int i = 1; i < sorted.Length; i++)
        {
            var next = sorted[i];
            if (curr[1] < next[0])
            {
                merged.Add(curr);
                curr = next;
                continue;
            }

            curr[1] = Math.Max(curr[1], next[1]);
        }
        merged.Add(curr);

        return [.. merged];
    }
}
