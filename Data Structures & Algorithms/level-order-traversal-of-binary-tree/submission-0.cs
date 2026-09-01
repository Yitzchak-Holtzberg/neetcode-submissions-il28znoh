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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();

        var source = new Queue<TreeNode>();
        if(root != null)
        source.Enqueue(root);

        var level = 0;

        while (source.Count > 0) {
            var lSize = source.Count;
            var hmm = new List<int>();
            for (int i = 0; i < lSize; i++) {
                var curr = source.Dequeue();
                hmm.Add(curr.val);

                if (curr.left != null) {
                    source.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    source.Enqueue(curr.right);
                }
            }
            result.Add(hmm);
            level++;
        }
        return result;
    }
}
