using AlgoPatternDrills.Common;

namespace AlgoPatternDrills.Patterns;

public static class TreeDfsBst
{
    // WORKED SAMPLE
    // Recursive DFS has three positions for Process(node): before, between, or after children.
    public static List<int> ReferencePreorder(TreeNode? root)
    {
        var values = new List<int>();

        void Visit(TreeNode? node)
        {
            if (node is null)
                return;

            values.Add(node.Value);
            Visit(node.Left);
            Visit(node.Right);
        }

        Visit(root);
        return values;
    }

    // 1. Return preorder traversal: node, left, right.
    public static IList<int> Preorder(TreeNode? root) =>
        throw new NotImplementedException();

    // 2. Return inorder traversal: left, node, right.
    public static IList<int> Inorder(TreeNode? root) =>
        throw new NotImplementedException();

    // 3. Return postorder traversal: left, right, node.
    public static IList<int> Postorder(TreeNode? root) =>
        throw new NotImplementedException();

    // 4. Return the maximum depth.
    public static int MaxDepth(TreeNode? root) =>
        throw new NotImplementedException();

    // 5. Return true when the two trees have identical shape and values.
    public static bool SameTree(TreeNode? first, TreeNode? second) =>
        throw new NotImplementedException();

    // 6. Invert the tree in place and return the root.
    public static TreeNode? Invert(TreeNode? root) =>
        throw new NotImplementedException();

    // 7. Insert value into a binary-search tree and return the root.
    public static TreeNode InsertBst(TreeNode? root, int value) =>
        throw new NotImplementedException();

    // 8. Validate strict binary-search-tree ordering.
    public static bool IsValidBst(TreeNode? root) =>
        throw new NotImplementedException();
}
