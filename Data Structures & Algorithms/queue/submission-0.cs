class Deque {
    private Node _tail;
    private Node _head;

    public bool isEmpty() => _tail is null;

    public void append(int value) {
        var newNode = new Node
        {
            val = value,
            prev = _tail,
        };

        if (_tail is null)
        {
            _tail = newNode;
            _head = newNode;
        }
        else
        {
            _tail.next = newNode;
            _tail = _tail.next;
        }
    }

    public void appendleft(int value) {
        var newNode = new Node
        {
            val = value,
            next = _head,
        };

        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _head.prev = newNode;
            _head = _head.prev;
        }
    }

    public int pop() {
        var res = _tail?.val;

        _tail = _tail?.prev;
        if (_tail is null)
        {
            _head = null;
        }
        else
        {
            _tail.next = null;
        }

        return res ?? -1;
    }

    public int popleft() {
        var res = _head?.val;

        _head = _head?.next;
        if (_head is null)
        {
            _tail = null;
        }
        else
        {
            _head.prev = null;
        }


        return res ?? -1;
    }

    private class Node
    {
        public int val;
        
        public Node next;

        public Node prev;
    }
}
