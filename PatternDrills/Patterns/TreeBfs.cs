using AlgoPatternDrills.Common;

namespace AlgoPatternDrills.Patterns;

public static class TreeBfs
{
    // WORKED SAMPLE
    // Snapshot queue.Count before processing a level because children change the queue.
    public static IList<IList<int>> ReferenceLevelOrder(TreeNode? root)
    {
        var levels = new List<IList<int>>();

        if (root is null)
            return levels;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            var level = new List<int>(levelSize);

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();
                level.Add(node.Value);

                if (node.Left is not null)
                    queue.Enqueue(node.Left);

                if (node.Right is not null)
                    queue.Enqueue(node.Right);
            }

            levels.Add(level);
        }

        return levels;
    }

    // 1. Return values grouped by level.
    public static IList<IList<int>> LevelOrder(TreeNode? root) =>
        throw new NotImplementedException();

    // 2. Return the rightmost visible value at each level.
    public static IList<int> RightSideView(TreeNode? root) =>
        throw new NotImplementedException();

    // 3. Return the average value at each level.
    public static IList<double> AverageOfLevels(TreeNode? root) =>
        throw new NotImplementedException();

    // 4. Return the minimum root-to-leaf depth.
    public static int MinimumDepth(TreeNode? root) =>
        throw new NotImplementedException();

    // 5. Return levels in alternating left-right and right-left order.
    public static IList<IList<int>> ZigzagLevelOrder(TreeNode? root) =>
        throw new NotImplementedException();

    // 6. Return the largest value on each level.
    public static IList<int> LargestValuePerLevel(TreeNode? root) =>
        throw new NotImplementedException();

    // 7. Return the sum of values on the deepest level.
    public static int DeepestLeavesSum(TreeNode? root) =>
        throw new NotImplementedException();

    // 8. Return true when two nodes with the supplied values are cousins:
    // same depth, different parents.
    public static bool AreCousins(TreeNode? root, int firstValue, int secondValue) =>
        throw new NotImplementedException();
}
