using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class TreeBfsTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Level-order traversal", TestLevelOrder),
        new(2, "Right-side view", TestRightSideView),
        new(3, "Average of levels", TestAverages),
        new(4, "Minimum depth", TestMinimumDepth),
        new(5, "Zigzag traversal", TestZigzag),
        new(6, "Largest value per level", TestLargestValues),
        new(7, "Deepest leaves sum", TestDeepestLeaves),
        new(8, "Cousins in a tree", TestCousins)
    ];

    private static void TestLevelOrder()
    {
        IList<IList<int>> levels = TreeBfs.LevelOrder(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7));
        AssertLevels([[3], [9, 20], [15, 7]], levels);
    }

    private static void TestRightSideView()
    {
        AssertEx.SequenceEqual([1, 3, 4], TreeBfs.RightSideView(TreeNode.FromLevelOrder(1, 2, 3, null, 5, null, 4)));
        AssertEx.SequenceEqual([], TreeBfs.RightSideView(null));
    }

    private static void TestAverages()
    {
        AssertEx.SequenceEqual([3.0, 14.5, 11.0], TreeBfs.AverageOfLevels(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7)));
    }

    private static void TestMinimumDepth()
    {
        AssertEx.Equal(2, TreeBfs.MinimumDepth(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7)));
        AssertEx.Equal(0, TreeBfs.MinimumDepth(null));
    }

    private static void TestZigzag()
    {
        IList<IList<int>> levels = TreeBfs.ZigzagLevelOrder(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7));
        AssertLevels([[3], [20, 9], [15, 7]], levels);
    }

    private static void TestLargestValues()
    {
        AssertEx.SequenceEqual([1, 3, 9], TreeBfs.LargestValuePerLevel(TreeNode.FromLevelOrder(1, 3, 2, 5, 3, null, 9)));
    }

    private static void TestDeepestLeaves()
    {
        TreeNode? root = TreeNode.FromLevelOrder(1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8);
        AssertEx.Equal(15, TreeBfs.DeepestLeavesSum(root));
    }

    private static void TestCousins()
    {
        AssertEx.True(TreeBfs.AreCousins(TreeNode.FromLevelOrder(1, 2, 3, 4, null, null, 5), 4, 5));
        AssertEx.False(TreeBfs.AreCousins(TreeNode.FromLevelOrder(1, 2, 3, 4), 3, 4));
    }

    private static void AssertLevels(int[][] expected, IList<IList<int>> actual)
    {
        AssertEx.Equal(expected.Length, actual.Count);

        for (int i = 0; i < expected.Length; i++)
            AssertEx.SequenceEqual(expected[i], actual[i]);
    }
}
