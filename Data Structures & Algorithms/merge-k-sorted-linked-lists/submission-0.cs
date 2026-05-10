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
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length <= 1)
        {
            return lists.FirstOrDefault();
        }

        return MergeKListsImpl(lists, 0, lists.Length - 1);
    }

    private ListNode MergeKListsImpl(ListNode[] lists, int s, int e)
    {
        if (e - s == 0)
        {
            return lists[s];
        }

        int m = s + ((e - s) / 2);
        var left = MergeKListsImpl(lists, s, m);
        var right = MergeKListsImpl(lists, m + 1, e);

        return MergeSortedLists(left, right);
    }

    private ListNode MergeSortedLists(ListNode left, ListNode right)
    {
        ListNode head = new();
        ListNode curr = head;

        while (left is not null && right is not null)
        {
            ListNode smallest;
            if (left.val <= right.val)
            {
                smallest = left;
                left = left.next;
            }
            else
            {
                smallest = right;
                right = right.next;
            }

            curr.next = smallest;
            curr = curr.next;
        }

        curr.next = left ?? right;

        return head.next;
    }
}



