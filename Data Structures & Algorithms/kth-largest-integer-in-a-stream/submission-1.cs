public class KthLargest {
    private int ix;
    private PriorityQueue<int, int> maxHeap = new(
        Comparer<int>.Create((a, b) => b.CompareTo(a)));

    public KthLargest(int k, int[] nums) {
        ix = k;

        foreach (var num in nums)
        {
            maxHeap.Enqueue(num, num);
        }
    }
    
    public int Add(int val) {
        maxHeap.Enqueue(val, val);

        int[] popped = new int[ix];
        int res = 0;
        for (int i = 0; i < ix; i++)
        {
            res = maxHeap.Dequeue();
            popped[i] = res;
        }

        foreach (var num in popped)
        {
            maxHeap.Enqueue(num, num);
        }

        return res;
    }
}
