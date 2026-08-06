using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class TwoPointersTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Loose palindrome", TestLoosePalindrome),
        new(2, "Reverse characters", TestReverse),
        new(3, "Pair sum in sorted array", TestPairSumSorted),
        new(4, "Move zeros", TestMoveZeros),
        new(5, "Remove target", TestRemoveTarget),
        new(6, "Sorted squares", TestSortedSquares),
        new(7, "Merge sorted arrays", TestMergeSorted),
        new(8, "Sort colours", TestSortColours)
    ];

    private static void TestLoosePalindrome()
    {
        AssertEx.True(TwoPointers.IsLoosePalindrome("A man, a plan, a canal: Panama"));
        AssertEx.False(TwoPointers.IsLoosePalindrome("race a car"));
        AssertEx.True(TwoPointers.IsLoosePalindrome(" "));
    }

    private static void TestReverse()
    {
        char[] chars = ['h', 'e', 'l', 'l', 'o'];
        TwoPointers.Reverse(chars);
        AssertEx.SequenceEqual(['o', 'l', 'l', 'e', 'h'], chars);
    }

    private static void TestPairSumSorted()
    {
        AssertEx.SequenceEqual([1, 2], TwoPointers.PairSumSorted([2, 7, 11, 15], 9));
        AssertEx.SequenceEqual([1, 3], TwoPointers.PairSumSorted([-1, 0, 3, 8], 2));
    }

    private static void TestMoveZeros()
    {
        int[] nums = [0, 1, 0, 3, 12];
        TwoPointers.MoveZeros(nums);
        AssertEx.SequenceEqual([1, 3, 12, 0, 0], nums);
    }

    private static void TestRemoveTarget()
    {
        int[] nums = [3, 2, 2, 3];
        int length = TwoPointers.RemoveTarget(nums, 3);
        AssertEx.Equal(2, length);
        AssertEx.SequenceEqual([2, 2], nums.Take(length));
    }

    private static void TestSortedSquares()
    {
        AssertEx.SequenceEqual([0, 1, 9, 16, 100], TwoPointers.SortedSquares([-4, -1, 0, 3, 10]));
        AssertEx.SequenceEqual([4, 9, 9, 49, 121], TwoPointers.SortedSquares([-7, -3, 2, 3, 11]));
    }

    private static void TestMergeSorted()
    {
        int[] first = [1, 2, 3, 0, 0, 0];
        TwoPointers.MergeSorted(first, 3, [2, 5, 6], 3);
        AssertEx.SequenceEqual([1, 2, 2, 3, 5, 6], first);
    }

    private static void TestSortColours()
    {
        int[] nums = [2, 0, 2, 1, 1, 0];
        TwoPointers.SortColours(nums);
        AssertEx.SequenceEqual([0, 0, 1, 1, 2, 2], nums);
    }
}
