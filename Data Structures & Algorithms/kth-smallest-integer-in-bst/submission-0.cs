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
    public int KthSmallest(TreeNode root, int k) {
        var a = new List<int>();
        exhaust(root, a);
        return a[k - 1];
    }

    public void exhaust(TreeNode root, List<int> a) {
        if (root == null) {
            return;
        }

        exhaust(root.left, a);
        a.Add(root.val);
        exhaust(root.right, a);
    }
}
