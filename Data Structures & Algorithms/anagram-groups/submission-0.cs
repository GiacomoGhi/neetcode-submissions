public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<int, List<string>> store = [];
        Dictionary<string, int> sfreq = [];
        foreach (var s in strs)
        {
            if (!store.TryGetValue(s.Length, out var list))
            {
                list = new();
                store[s.Length] = list;
            }
            list.Add(s);

            if (!sfreq.ContainsKey(s))
            {
                sfreq[s] = 0;
            }

            sfreq[s]++;
        }

        List<List<string>> res = [];
        foreach (var s in strs)
        {
            if (!sfreq.ContainsKey(s))
            {
                continue;
            }

            List<string> curr = [];
            res.Add(curr);
            for (int i = 0; i < sfreq[s]; i++)
            {
                curr.Add(s);
            }
            sfreq.Remove(s);
            var freq = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!freq.ContainsKey(c))
                {
                    freq[c] = 0;
                }
                freq[c]++;
            }

            foreach (var t in store[s.Length])
            {
                if (!sfreq.ContainsKey(t)
                    || !IsAnagram(freq, t))
                {
                    continue;
                }

                curr.Add(t);
                sfreq[t]--;
                if (sfreq[t] == 0)
                {
                    sfreq.Remove(t);
                }
            }
        }

        return res;
    }

    bool IsAnagram(Dictionary<char, int> freq, string s)
    {
        freq = freq
            .ToDictionary(
                f => f.Key,
                f => f.Value);

        foreach (var c in s)
        {
            if (!freq.ContainsKey(c))
            {
                return false;
            }

            if (freq[c] == 1)
            {
                freq.Remove(c);
            }
            else
            {
                freq[c]--;
            }
        }

        return freq.Count == 0;
    }
}
