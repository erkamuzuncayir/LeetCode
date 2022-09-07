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
    public ListNode MiddleNode(ListNode head) 
    {
        // Creates two pointer
        ListNode mid = head;
        ListNode end = head;
        
        // Traverse nodes until the reach end of the list and finds middle node.
        while ( end != null && end.next != null )
        {
            end = end.next.next;
            mid = mid.next;
        }
        
        // Returns from middle to end as a linked list.
        return mid;
    }
}
