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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode(0);
        var node = result;

        var tmp = 0;
        while (l1 != null || l2 != null) {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + tmp;
            
            tmp = sum / 10;
            
            if (sum > 9) {
                sum %= 10;
            }
            
            node.next = new ListNode(sum);
            
            node = node.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (tmp == 0 && l1 == null && l2 == null) {
            return result.next;
        }

        if (tmp != 0 && l1 == null && l2 == null) {
            node.next = new ListNode(tmp);
            return result.next;
        }

        return result.next;
    }
}
