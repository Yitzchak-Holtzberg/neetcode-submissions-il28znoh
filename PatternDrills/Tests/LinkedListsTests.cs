using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class LinkedListsTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Reverse list", TestReverse),
        new(2, "Merge sorted lists", TestMergeSorted),
        new(3, "Middle node", TestMiddle),
        new(4, "Cycle detection", TestCycle),
        new(5, "Remove nth from end", TestRemoveNth),
        new(6, "Delete sorted duplicates", TestDeleteDuplicates),
        new(7, "Palindrome list", TestPalindrome),
        new(8, "Reorder list", TestReorder)
    ];

    private static void TestReverse()
    {
        ListNode? result = LinkedLists.Reverse(ListNode.FromArray(1, 2, 3, 4));
        AssertEx.SequenceEqual([4, 3, 2, 1], ListNode.ToArray(result));
        AssertEx.SequenceEqual([], ListNode.ToArray(LinkedLists.Reverse(null)));
    }

    private static void TestMergeSorted()
    {
        ListNode? result = LinkedLists.MergeSorted(ListNode.FromArray(1, 2, 4), ListNode.FromArray(1, 3, 4));
        AssertEx.SequenceEqual([1, 1, 2, 3, 4, 4], ListNode.ToArray(result));
    }

    private static void TestMiddle()
    {
        AssertEx.Equal(3, LinkedLists.Middle(ListNode.FromArray(1, 2, 3, 4, 5))!.Value);
        AssertEx.Equal(4, LinkedLists.Middle(ListNode.FromArray(1, 2, 3, 4, 5, 6))!.Value);
    }

    private static void TestCycle()
    {
        ListNode first = new(1);
        ListNode second = new(2);
        ListNode third = new(3);
        first.Next = second;
        second.Next = third;
        third.Next = second;

        AssertEx.True(LinkedLists.HasCycle(first));
        AssertEx.False(LinkedLists.HasCycle(ListNode.FromArray(1, 2, 3)));
    }

    private static void TestRemoveNth()
    {
        ListNode? result = LinkedLists.RemoveNthFromEnd(ListNode.FromArray(1, 2, 3, 4, 5), 2);
        AssertEx.SequenceEqual([1, 2, 3, 5], ListNode.ToArray(result));
        result = LinkedLists.RemoveNthFromEnd(ListNode.FromArray(1), 1);
        AssertEx.SequenceEqual([], ListNode.ToArray(result));
    }

    private static void TestDeleteDuplicates()
    {
        ListNode? result = LinkedLists.DeleteSortedDuplicates(ListNode.FromArray(1, 1, 2, 3, 3));
        AssertEx.SequenceEqual([1, 2, 3], ListNode.ToArray(result));
    }

    private static void TestPalindrome()
    {
        AssertEx.True(LinkedLists.IsPalindrome(ListNode.FromArray(1, 2, 2, 1)));
        AssertEx.False(LinkedLists.IsPalindrome(ListNode.FromArray(1, 2)));
    }

    private static void TestReorder()
    {
        ListNode? head = ListNode.FromArray(1, 2, 3, 4);
        LinkedLists.Reorder(head);
        AssertEx.SequenceEqual([1, 4, 2, 3], ListNode.ToArray(head));

        head = ListNode.FromArray(1, 2, 3, 4, 5);
        LinkedLists.Reorder(head);
        AssertEx.SequenceEqual([1, 5, 2, 4, 3], ListNode.ToArray(head));
    }
}
