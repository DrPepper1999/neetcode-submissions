/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
    var res = 0;

     int Dfs(TreeNode curr) {
        if (curr == null) {
            return 0;
        }

        var left = Dfs(curr.left);
        var right = Dfs(curr.right);
        res = Math.Max(res, left + right);
        return 1 + Math.Max(left, right);
    }

    Dfs(root);
    return res;
    }
}
