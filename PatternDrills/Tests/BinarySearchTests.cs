using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class BinarySearchTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Exact search", TestExactSearch),
        new(2, "First occurrence", TestFirstOccurrence),
        new(3, "Last occurrence", TestLastOccurrence),
        new(4, "Lower bound", TestLowerBound),
        new(5, "Search insert position", TestSearchInsert),
        new(6, "Search matrix", TestSearchMatrix),
        new(7, "Integer square root", TestSquareRoot),
        new(8, "Minimum eating speed", TestEatingSpeed)
    ];

    private static void TestExactSearch()
    {
        AssertEx.Equal(4, BinarySearch.ExactSearch([-1, 0, 3, 5, 9, 12], 9));
        AssertEx.Equal(-1, BinarySearch.ExactSearch([-1, 0, 3, 5, 9, 12], 2));
    }

    private static void TestFirstOccurrence()
    {
        AssertEx.Equal(1, BinarySearch.FirstOccurrence([1, 2, 2, 2, 3], 2));
        AssertEx.Equal(-1, BinarySearch.FirstOccurrence([1, 2, 3], 4));
    }

    private static void TestLastOccurrence()
    {
        AssertEx.Equal(3, BinarySearch.LastOccurrence([1, 2, 2, 2, 3], 2));
        AssertEx.Equal(-1, BinarySearch.LastOccurrence([1, 2, 3], 4));
    }

    private static void TestLowerBound()
    {
        AssertEx.Equal(2, BinarySearch.LowerBound([1, 3, 5, 7], 4));
        AssertEx.Equal(4, BinarySearch.LowerBound([1, 3, 5, 7], 9));
        AssertEx.Equal(0, BinarySearch.LowerBound([1, 3, 5, 7], 0));
    }

    private static void TestSearchInsert()
    {
        AssertEx.Equal(2, BinarySearch.SearchInsertPosition([1, 3, 5, 6], 5));
        AssertEx.Equal(1, BinarySearch.SearchInsertPosition([1, 3, 5, 6], 2));
        AssertEx.Equal(4, BinarySearch.SearchInsertPosition([1, 3, 5, 6], 7));
    }

    private static void TestSearchMatrix()
    {
        int[][] matrix =
        [
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        ];

        AssertEx.True(BinarySearch.SearchMatrix(matrix, 3));
        AssertEx.False(BinarySearch.SearchMatrix(matrix, 13));
    }

    private static void TestSquareRoot()
    {
        AssertEx.Equal(2, BinarySearch.IntegerSquareRoot(4));
        AssertEx.Equal(2, BinarySearch.IntegerSquareRoot(8));
        AssertEx.Equal(46339, BinarySearch.IntegerSquareRoot(2_147_395_599));
    }

    private static void TestEatingSpeed()
    {
        AssertEx.Equal(4, BinarySearch.MinimumEatingSpeed([3, 6, 7, 11], 8));
        AssertEx.Equal(30, BinarySearch.MinimumEatingSpeed([30, 11, 23, 4, 20], 5));
        AssertEx.Equal(23, BinarySearch.MinimumEatingSpeed([30, 11, 23, 4, 20], 6));
    }
}
