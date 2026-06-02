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
    public bool HasCycle(ListNode head) {
        while (head is not null)
        {
            if (head.val == int.MinValue)
            {
                return true;
            }
            head.val = int.MinValue;
            head = head.next;
        }

        return false;
    }
}
