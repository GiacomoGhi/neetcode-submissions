/*
    _q2 = [];
    _q1 = [4, 3, 2, 1];
*/

public class MyStack {
    private Queue<int> _q1 = new();
    private Queue<int> _q2 = new();
    
    public void Push(int x) {
        _q2.Enqueue(x);
        while(_q1.Count > 0)
        {
            _q2.Enqueue(_q1.Dequeue());
        }

        (_q1, _q2) = (_q2, _q1);
    }
    
    public int Pop()
        => _q1.Dequeue();
    
    public int Top()
        => _q1.Peek();
    
    public bool Empty()
        => _q1.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */