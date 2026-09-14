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
    public bool HasPathSum(TreeNode root, int targetSum) {
        var remaining = targetSum;
        return HasSum(root, remaining);
    }

    public bool HasSum(TreeNode root, int remaining) {
        if (root == null) {
            return false;
        }
        remaining -= root.val;
        if (root.left == null && root.right == null && remaining == 0) {
            return true;
        }
        if (root.left == null && root.right == null) {
            return false;
        }

        if(HasSum(root.left, remaining)){
            return true;
        }

        if(HasSum(root.right, remaining)){
            return true;
        }
        return false;
    }
}