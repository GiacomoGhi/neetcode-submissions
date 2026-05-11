// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
/*

    pairs = [(5, "a"), (2, "b"), (9, "c")];



*/
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> res = [];

        for (int i = 0; i < pairs.Count; i++)
        {
            int j = i - 1;
            while (j >= 0 && pairs[j + 1].Key < pairs[j].Key)
            {
                (pairs[j + 1], pairs[j]) = (pairs[j], pairs[j + 1]);
                j--;
            }

            res.Add([.. pairs]);
        }

        return res;
    }
}
