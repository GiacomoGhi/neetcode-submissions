public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int[] counts = [0, 0];
        foreach (var s in students)
        {
            counts[s]++;
        }

        foreach (var s in sandwiches)
        {
            if (counts[s] == 0)
            {
                return counts.Sum();
            }
            counts[s]--;
        }

        return 0;
    }
}