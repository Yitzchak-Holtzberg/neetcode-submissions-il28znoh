using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class SortingHeapsTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Insertion sort", TestInsertionSort),
        new(2, "Merge sort", TestMergeSort),
        new(3, "Kth largest", TestKthLargest),
        new(4, "Top-k frequent", TestTopKFrequent),
        new(5, "K closest points", TestKClosest),
        new(6, "Merge k sorted arrays", TestMergeKArrays),
        new(7, "Merge intervals", TestMergeIntervals),
        new(8, "Minimum connection cost", TestConnectionCost)
    ];

    private static void TestInsertionSort()
    {
        int[] nums = [5, 2, 4, 6, 1, 3];
        SortingHeaps.InsertionSort(nums);
        AssertEx.SequenceEqual([1, 2, 3, 4, 5, 6], nums);
    }

    private static void TestMergeSort()
    {
        int[] nums = [5, 1, 1, 2, 0, 0];
        SortingHeaps.MergeSort(nums);
        AssertEx.SequenceEqual([0, 0, 1, 1, 2, 5], nums);
    }

    private static void TestKthLargest()
    {
        AssertEx.Equal(5, SortingHeaps.KthLargest([3, 2, 1, 5, 6, 4], 2));
        AssertEx.Equal(4, SortingHeaps.KthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4));
    }

    private static void TestTopKFrequent()
    {
        AssertEx.UnorderedEqual([1, 2], SortingHeaps.TopKFrequent([1, 1, 1, 2, 2, 3], 2));
        AssertEx.UnorderedEqual([1], SortingHeaps.TopKFrequent([1], 1));
    }

    private static void TestKClosest()
    {
        int[][] result = SortingHeaps.KClosest([[1, 3], [-2, 2]], 1);
        AssertEx.Equal(1, result.Length);
        AssertEx.SequenceEqual([-2, 2], result[0]);

        result = SortingHeaps.KClosest([[3, 3], [5, -1], [-2, 4]], 2);
        var normalised = result.Select(point => $"{point[0]},{point[1]}");
        AssertEx.UnorderedEqual(["3,3", "-2,4"], normalised);
    }

    private static void TestMergeKArrays()
    {
        AssertEx.SequenceEqual(
            [1, 1, 2, 3, 4, 4, 5, 6],
            SortingHeaps.MergeKSortedArrays([[1, 4, 5], [1, 3, 4], [2, 6]]));
        AssertEx.SequenceEqual([], SortingHeaps.MergeKSortedArrays([]));
    }

    private static void TestMergeIntervals()
    {
        int[][] result = SortingHeaps.MergeIntervals([[1, 3], [2, 6], [8, 10], [15, 18]]);
        AssertEx.Equal(3, result.Length);
        AssertEx.SequenceEqual([1, 6], result[0]);
        AssertEx.SequenceEqual([8, 10], result[1]);
        AssertEx.SequenceEqual([15, 18], result[2]);
    }

    private static void TestConnectionCost()
    {
        AssertEx.Equal(14, SortingHeaps.MinimumConnectionCost([2, 4, 3]));
        AssertEx.Equal(30, SortingHeaps.MinimumConnectionCost([1, 8, 3, 5]));
    }
}
