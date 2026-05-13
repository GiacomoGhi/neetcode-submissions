public class LRUCache
{
    private ListNode _right;
    private ListNode _left;
    private int _capacity;
    private Dictionary<int, ListNode> _cache;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _cache = new(capacity);
        _right = new(0,0);
        _left = new(0,0);

        _right.prev = _left;
        _left.next = _right;
    }
    
    public int Get(int key) {
        if (!_cache.TryGetValue(key, out var node))
        {
            return -1;
        }

        Remove(node);
        Insert(node);

        return node.val;
    }
    
    public void Put(int key, int value) {
        if (_cache.TryGetValue(key, out var node))
        {
            Remove(node);
        }
        node = new(key, value);
        Insert(node);
        _cache[key] = node;

        if (_cache.Count > _capacity)
        {
            var lru = _left.next;
            Remove(lru);
            _cache.Remove(lru.key);
        }
    }

    private void Insert(ListNode node)
    {
        _right.prev.next = node;
        node.prev = _right.prev;
        node.next = _right;
        _right.prev = node;
    }

    private void Remove(ListNode node)
    {
        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    private class ListNode(int key, int value)
    {
        public int key = key;
        public int val = value;
        public ListNode prev;
        public ListNode next;
    }
}
