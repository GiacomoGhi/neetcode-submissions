/*
    temp = 3;
    arr = [2,4,5,2,2,-1]
    max = 2;
*/

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if (arr.Length == 0)
        {
            return [];
        }

        var max = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = max;

            if (temp > max)
            {
                max = temp;
            }
        }

        return arr;
    }
}