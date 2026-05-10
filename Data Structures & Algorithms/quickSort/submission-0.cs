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
    public List<Pair> QuickSort(List<Pair> pairs) {
        QuickSortImpl(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    private void QuickSortImpl(List<Pair> pairs, int s, int e)
    {
        if (e - s + 1 <= 1)
        {
            return;
        }

        var left = s;

        for (int i = s; i <= e; i++)
        {
            if (pairs[i].Key < pairs[e].Key)
            {
                (pairs[left], pairs[i]) = (pairs[i], pairs[left]);
                left++;
            }
        }

        (pairs[left], pairs[e]) = (pairs[e], pairs[left]);
        
        QuickSortImpl(pairs, s, left - 1);
        QuickSortImpl(pairs, left + 1, e);

        return;
    }
}
