/*

    |---|
    |---|
    |-----|
       |--|
        |---|
          |---|
            |---|
          |-------|
              |---|
*/

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals.Length == 1)
        {
            return 0;
        }

        intervals = [.. intervals
            .OrderBy(x => x[1])];

        var removed = 0;
        var prevEnd = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < prevEnd)
            {
                removed++;
            }
            else
            {
                prevEnd = intervals[i][1];
            }
        }

        return removed;
    }
}
