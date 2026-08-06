namespace AlgoPatternDrills.Common;

public sealed class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public static TreeNode? FromLevelOrder(params int?[] values)
    {
        if (values.Length == 0 || values[0] is null)
            return null;

        var root = new TreeNode(values[0]!.Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int index = 1;

        while (queue.Count > 0 && index < values.Length)
        {
            TreeNode node = queue.Dequeue();

            if (index < values.Length && values[index] is int leftValue)
            {
                var leftNode = new TreeNode(leftValue);
                node.Left = leftNode;
                queue.Enqueue(leftNode);
            }

            index++;

            if (index < values.Length && values[index] is int rightValue)
            {
                var rightNode = new TreeNode(rightValue);
                node.Right = rightNode;
                queue.Enqueue(rightNode);
            }

            index++;
        }

        return root;
    }
}
