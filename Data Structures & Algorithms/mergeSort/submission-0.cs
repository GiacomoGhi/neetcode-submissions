// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {

        MergeSortImpl(0, pairs.Count - 1);
        return pairs;

        void MergeSortImpl(int s, int e)
        {
            if (s >= e)
            {
                return;
            }

            var m = s + ((e - s) / 2);
            MergeSortImpl(s, m);
            MergeSortImpl(m + 1, e);

            MergeSortedArrays(pairs, s, m, e);
        }
    }

    private void MergeSortedArrays(List<Pair> pairs, int s, int m, int e)
    {
        if (e - s + 1 <= 1)
        {
            return;
        }

        var left = pairs[s .. (m + 1)];
        var right = pairs[(m + 1) .. (e + 1)];

        int i = 0, j = 0, k = s;

        while (i < left.Count && j < right.Count)
        {
            if (left[i].Key <= right[j].Key)
            {
                pairs[k++] = left[i++];
            }
            else
            {
                pairs[k++] = right[j++];
            }
        }

       while (i < left.Count) pairs[k++] = left[i++];
       while (j < right.Count) pairs[k++] = right[j++];
    }
}



