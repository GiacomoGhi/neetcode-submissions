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
    list1 = [2,4], list2 = [1,3,5]


    dummy: -1 ->
    curr: -1 -> 1



 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var dummy = new ListNode(-1);
        var curr = dummy;

        while (list1 is not null && list2 is not null)
        {
            ListNode next;
            if (list1.val <= list2.val)
            {
                next = list1;
                list1 = list1.next;
            }
            else
            {
                next = list2;
                list2 = list2.next;
            }

            curr.next = next;
            curr = curr.next;
        }

        curr.next = list1 ?? list2;

        return dummy.next;
    }
}