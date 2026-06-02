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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var curr = head;
        var count = 0;
        while (curr is not null)
        {
            curr = curr.next;
            count++;
        }

        if (count <= 1)
        {
            return null;
        }
        if (count == n)
        {
            return head.next;
        }

        ListNode prev = null;
        curr = head;
        for (int i = 0; i < count - n; i++)
        {
            prev = curr;
            curr = curr.next;
        }

        prev.next = curr.next;
        return head;
    }
}
