using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class TreeDfsBstTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Preorder traversal", TestPreorder),
        new(2, "Inorder traversal", TestInorder),
        new(3, "Postorder traversal", TestPostorder),
        new(4, "Maximum depth", TestMaxDepth),
        new(5, "Same tree", TestSameTree),
        new(6, "Invert tree", TestInvert),
        new(7, "Insert into BST", TestInsertBst),
        new(8, "Validate BST", TestValidateBst)
    ];

    private static TreeNode? Sample() => TreeNode.FromLevelOrder(1, 2, 3, 4, 5, null, 6);

    private static void TestPreorder()
    {
        AssertEx.SequenceEqual([1, 2, 4, 5, 3, 6], TreeDfsBst.Preorder(Sample()));
        AssertEx.SequenceEqual([], TreeDfsBst.Preorder(null));
    }

    private static void TestInorder()
    {
        AssertEx.SequenceEqual([4, 2, 5, 1, 3, 6], TreeDfsBst.Inorder(Sample()));
    }

    private static void TestPostorder()
    {
        AssertEx.SequenceEqual([4, 5, 2, 6, 3, 1], TreeDfsBst.Postorder(Sample()));
    }

    private static void TestMaxDepth()
    {
        AssertEx.Equal(3, TreeDfsBst.MaxDepth(Sample()));
        AssertEx.Equal(0, TreeDfsBst.MaxDepth(null));
    }

    private static void TestSameTree()
    {
        AssertEx.True(TreeDfsBst.SameTree(TreeNode.FromLevelOrder(1, 2, 3), TreeNode.FromLevelOrder(1, 2, 3)));
        AssertEx.False(TreeDfsBst.SameTree(TreeNode.FromLevelOrder(1, 2), TreeNode.FromLevelOrder(1, null, 2)));
    }

    private static void TestInvert()
    {
        TreeNode? result = TreeDfsBst.Invert(TreeNode.FromLevelOrder(4, 2, 7, 1, 3, 6, 9));
        AssertEx.SequenceEqual([4, 7, 9, 6, 2, 3, 1], TreeDfsBst.Preorder(result));
    }

    private static void TestInsertBst()
    {
        TreeNode root = TreeDfsBst.InsertBst(TreeNode.FromLevelOrder(4, 2, 7, 1, 3), 5);
        AssertEx.SequenceEqual([1, 2, 3, 4, 5, 7], TreeDfsBst.Inorder(root));
    }

    private static void TestValidateBst()
    {
        AssertEx.True(TreeDfsBst.IsValidBst(TreeNode.FromLevelOrder(2, 1, 3)));
        AssertEx.False(TreeDfsBst.IsValidBst(TreeNode.FromLevelOrder(5, 1, 4, null, null, 3, 6)));
    }
}
