public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int s = 0;
        int e = matrix.Length - 1;
        int row = 0;

        while (s <= e)
        {
            row = (s + e) / 2;
            if (matrix[row][0] > target)
            {
                e = row - 1;
            }
            else if (matrix[row][^1] < target)
            {
                s = row + 1;
            }
            else
            {
                break;
            }
        }

        if (s > e)
        {
            return false;
        }

        int[] arr = matrix[row];
        s = 0;
        e = arr.Length - 1;
        int mid;
        while (s <= e)
        {
            mid = (s + e) / 2;
            if (arr[mid] > target)
            {
                e = mid - 1;
            }
            else if (arr[mid] < target)
            {
                s = mid + 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}
