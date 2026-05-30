public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqs = [];
        foreach (var n in nums)
        {
            freqs[n] = 1 + freqs.GetValueOrDefault(n);
        }

        List<int>[] store = new List<int>[nums.Length + 1];
        foreach (var f in freqs)
        {
            if (store[f.Value] is null)
            {
                store[f.Value] = [];
            }

            store[f.Value].Add(f.Key);
        }

        int[] res = new int[k];
        var ix = 0;
        for(int i = store.Length - 1; i >= 0; i--)
        {
            foreach(var n in store[i] ?? [])
            {
                res[ix++] = n;
                if (ix == res.Length)
                {
                    return res;
                }
            }
        }

        return res;
    }
}
