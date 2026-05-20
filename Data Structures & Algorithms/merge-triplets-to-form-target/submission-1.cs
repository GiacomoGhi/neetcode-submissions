/*
    [[2,5,6],[1,4,4],[5,7,5]]

    [2,5,6]                             [1,4,4],[5,7,5]

    [2,5,6] - [2,5,6],[1,4,4] - [2,5,6] [5,7,5] - [1,4,4],[5,7,5] - [5,7,5] - [1,4,4]


*/


public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        var (a, b, c) = (false, false, false);

        foreach (var t in triplets)
        {
            if (t[0] > target[0]
                || t[1] > target[1]
                || t[2] > target[2])
            {
                continue;
            }

            a |= t[0] == target[0];
            b |= t[1] == target[1];
            c |= t[2] == target[2];

            if (a && b && c)
            {
                return true;
            }
        }

        return false;
    }
}
