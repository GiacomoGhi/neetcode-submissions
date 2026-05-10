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

    1 2 3


    head = 1
    newHead = 1
    
 */

public class Solution {
    // public ListNode ReverseList(ListNode head) {
    //     ListNode prev = null;
    //     ListNode curr = head;
        
    //     while (curr is not null)
    //     {
    //         var temp = curr.next;
    //         curr.next = prev;
    //         prev = curr;
    //         curr = temp;
    //     }

    //     return prev;
    // }
    public ListNode ReverseList(ListNode head) {
        // if (head is null)
        // {
        //     return null;
        // }

        // if (head.next is null)
        // {
        //     return head;
        // }

        // var newHead = ReverseList(head.next);
        // head.next.next = head;
        // head.next = null;

        // return newHead;

        if (head is null)
        {
            return null;
        }

        ListNode prev = null;
        var curr = head;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }
}










