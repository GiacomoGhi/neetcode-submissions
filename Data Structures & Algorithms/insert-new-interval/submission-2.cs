public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = [];

        bool inserted = false;
        for (int i = 0; i < intervals.Length; i++)
        {
            if (!inserted)
            {
                if (intervals[i][1] < newInterval[0])
                {
                    res.Add(intervals[i]);
                }
                else if (intervals[i][0] > newInterval[1])
                {
                    res.Add(newInterval);
                    res.Add(intervals[i]);
                    inserted = true;
                }
                else
                {
                    inserted = true;
                    var start = Math.Min(intervals[i][0], newInterval[0]);
                    var end = Math.Max(intervals[i][1], newInterval[1]);
                    while (i + 1 < intervals.Length
                        && end >= intervals[i+1][0])
                    {
                        end = Math.Max(end, intervals[i+1][1]);
                        i++;
                    }

                    res.Add([start, end]);
                }
            }
            else
            {
                res.Add(intervals[i]);
            }
        }

        if (!inserted)
        {
            res.Add(newInterval);
        }

        return res.ToArray();
    }
}
