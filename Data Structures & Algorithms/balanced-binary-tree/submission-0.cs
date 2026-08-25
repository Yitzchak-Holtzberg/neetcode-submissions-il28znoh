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
    bool balanced;
    public bool IsBalanced(TreeNode root) {
        balanced = true;
        Height(root);
        return balanced;
    }
    private int Height(TreeNode node) {
        if (node == null) {
            return 0;
        }

        var leftH = Height(node.left);
        var rightH = Height(node.right);

        if (Math.Abs(leftH - rightH) > 1) {
            balanced = false;
        }

        return 1 + Math.Max(leftH, rightH);
    }
}
