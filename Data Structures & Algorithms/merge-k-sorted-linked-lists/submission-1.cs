/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }

    Input: lists = [[1,2,4],[1,3,5],[3,6]]
    
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0)
        {
            return null;
        }

        return MergeKListsImpl(0, lists.Length - 1);

        ListNode MergeKListsImpl(int s, int e)
        {
            if  (e - s + 1 <= 1)
            {
                return lists[s];
            }

            int m = (s + e) / 2;
            var left = MergeKListsImpl(s, m);
            var right = MergeKListsImpl(m + 1, e);

            return MergeSortedLists(left, right);
        }
    }

    private ListNode MergeSortedLists(ListNode left, ListNode right)
    {
        ListNode head = new ListNode(0);
        ListNode curr = head;
        while (left is not null && right is not null)
        {
            if (left.val <= right.val)
            {
                curr.next = left;
                left = left.next;
            }
            else
            {
                curr.next = right;
                right = right.next;
            }

            curr = curr.next;
        }

        curr.next = left ?? right;

        return head.next;
    }
}
