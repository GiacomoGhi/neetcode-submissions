// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }

/*
    [1, 2, 4, 6]


*/

// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        if (pairs.Count == 0)
        {
            return [];
        }

        QuickSortImpl(0, pairs.Count - 1);

        return pairs;

        void QuickSortImpl(int s, int e)
        {
            if (e - s + 1 <= 0)
            {
                return;
            }

            int pivot = pairs[e].Key;
            int left = s;

            for (int i = s; i < e; i++)
            {
                if (pairs[i].Key < pivot)
                {
                    (pairs[left], pairs[i]) = (pairs[i], pairs[left]);
                    left++;
                }
            }

            (pairs[left], pairs[e]) = (pairs[e], pairs[left]);

            QuickSortImpl(s, left - 1);
            QuickSortImpl(left + 1, e);
        }
    }
}
