/*
    stones = [2,3,6,2,4];
    
    maxHeap = [1];

    x = 2
    y = 2

    res = 1
*/


public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new(
            stones.Select(s => (s, s)), 
            Comparer<int>.Create((x, y) => y.CompareTo(x)));

        while(maxHeap.Count > 1)
        {
            var x = maxHeap.Dequeue();
            var y = maxHeap.Dequeue();

            if (x == y)
            {
                continue;
            }

            var t = x - y;
            maxHeap.Enqueue(t, t);
        }

        return maxHeap.Count == 1 ? maxHeap.Peek() : 0;
    }
}
