public class TimeMap {
    Dictionary<string, List<(string Value, int Timestamp)>> store = [];
    
    public void Set(string key, string value, int timestamp) {
        if (!store.TryGetValue(key, out var list))
        {
            list = [];
            store.Add(key, list);
        }

        list.Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if (!store.TryGetValue(key, out var list))
        {
            return "";
        }

        var s = 0;
        var e = list.Count - 1;
        var mid = 0;
        while (s <= e)
        {
            mid = (e + s) / 2;
            if (list[mid].Timestamp > timestamp)
            {
                e = mid - 1;
            }
            else if (list[mid].Timestamp < timestamp)
            {
                s = mid + 1;
            }
            else
            {
                return list[mid].Value;
            }
        }

        if (list[mid].Timestamp > timestamp)
        {
            return mid - 1 >= 0 ? list[(mid - 1)].Value : "";
        }
        return list[mid].Value;
    }
}


/*
    [1, 2, 4, 5, 6, 7, 8, 15]

    10


*/