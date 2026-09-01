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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();

        var source = new Queue<TreeNode>();
        if (root != null)
            source.Enqueue(root);

        while (source.Count > 0) {
            var lSize = source.Count;
            for (int i = 0; i < lSize; i++) {
                var curr = source.Dequeue();
                if(i == lSize -1)
                result.Add(curr.val);

                if (curr.left != null) {
                    source.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    source.Enqueue(curr.right);
                }
            }
        }
        return result;
    }
}
