public class MinStack {
    private readonly Stack<int> _values = [];
    private readonly Stack<int> _minValues = [];
    
    public void Push(int val)
    {
        if (_minValues.Count == 0 || val <= _minValues.Peek())
        {
            _minValues.Push(val);
        }

        _values.Push(val);
    }
    
    public int Pop() {
        var value = _values.Pop();

        if (value == _minValues.Peek())
        {
            _ = _minValues.Pop();
        }

        return value;
    }
    
    public int Top()
        => _values.Peek();
    
    public int GetMin()
        => _minValues.Peek();
}
