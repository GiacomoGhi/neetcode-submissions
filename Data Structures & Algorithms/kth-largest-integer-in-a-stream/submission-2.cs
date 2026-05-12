public class KthLargest {
    private int ix;
    private PriorityQueue<int, int> minHeap = new();

    public KthLargest(int k, int[] nums) {
        ix = k;

        foreach (var num in nums)
        {
            minHeap.Enqueue(num, num);
            if (minHeap.Count > ix)
            {
                minHeap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if (minHeap.Count > ix)
        {
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}
