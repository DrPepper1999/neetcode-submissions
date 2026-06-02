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
    public int MaxDepth(TreeNode root) {
        var result = 0;
        var visited = new HashSet<TreeNode>();
        var stack = new Stack<(int depth, TreeNode node)>();
        stack.Push((1, root));
        
        while (stack.Count > 0)
        {
            var (depth, node) = stack.Pop();

            if (node == null || !visited.Add(node))
            {
                continue;
            }

            result = Math.Max(result, depth);
            
            stack.Push((depth+1, node.left));
            stack.Push((depth+1, node.right));
        }

        return result;
    }
}
