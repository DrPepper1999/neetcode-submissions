/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        
        var origenToCopyNode = new Dictionary<Node, Node>();
        
        var result = new Node(head.val);

        origenToCopyNode.Add(head, result);

        var origNode = head.next;
        var copyNode = result;

        while (origNode != null) {
            copyNode.next = new Node(origNode.val);

            origenToCopyNode.Add(origNode, copyNode.next);

            copyNode = copyNode.next;
            origNode = origNode.next;
        }

        origNode = head;
        copyNode = result;

        while (origNode != null) {
            copyNode.random = origNode.random != null
                ? origenToCopyNode[origNode.random]
                : null;

            copyNode = copyNode.next;
            origNode = origNode.next;
        }

        return result;
    }
}
