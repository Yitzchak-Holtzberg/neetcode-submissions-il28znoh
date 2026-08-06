namespace AlgoPatternDrills.Common;

public sealed class ListNode
{
    public int Value { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(int value, ListNode? next = null)
    {
        Value = value;
        Next = next;
    }

    public static ListNode? FromArray(params int[] values)
    {
        var dummy = new ListNode(0);
        var tail = dummy;

        foreach (int value in values)
        {
            var node = new ListNode(value);
            tail.Next = node;
            tail = node;
        }

        return dummy.Next;
    }

    public static int[] ToArray(ListNode? head)
    {
        var values = new List<int>();
        var seen = new HashSet<ListNode>();

        while (head is not null)
        {
            if (!seen.Add(head))
                throw new InvalidOperationException("Cycle detected while converting a list to an array.");

            values.Add(head.Value);
            head = head.Next;
        }

        return values.ToArray();
    }
}
