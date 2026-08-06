using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class ArraysHashingTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Contains duplicate", TestContainsDuplicate),
        new(2, "Valid anagram", TestIsAnagram),
        new(3, "Two sum", TestTwoSum),
        new(4, "First repeated value", TestFirstRepeatedValue),
        new(5, "Most frequent value", TestMostFrequentValue),
        new(6, "Unique intersection", TestUniqueIntersection),
        new(7, "Unique frequencies", TestUniqueFrequencies),
        new(8, "Longest consecutive sequence", TestLongestConsecutive)
    ];

    private static void TestContainsDuplicate()
    {
        AssertEx.True(ArraysHashing.ContainsDuplicate([1, 2, 3, 1]));
        AssertEx.False(ArraysHashing.ContainsDuplicate([1, 2, 3, 4]));
        AssertEx.False(ArraysHashing.ContainsDuplicate([]));
    }

    private static void TestIsAnagram()
    {
        AssertEx.True(ArraysHashing.IsAnagram("listen", "silent"));
        AssertEx.False(ArraysHashing.IsAnagram("rat", "car"));
        AssertEx.True(ArraysHashing.IsAnagram("", ""));
    }

    private static void TestTwoSum()
    {
        int[] answer = ArraysHashing.TwoSum([2, 7, 11, 15], 9);
        AssertEx.SequenceEqual([0, 1], answer.Order());
        answer = ArraysHashing.TwoSum([3, 2, 4], 6);
        AssertEx.SequenceEqual([1, 2], answer.Order());
    }

    private static void TestFirstRepeatedValue()
    {
        AssertEx.Equal(3, ArraysHashing.FirstRepeatedValue([2, 1, 3, 5, 3, 2]));
        AssertEx.Equal(-1, ArraysHashing.FirstRepeatedValue([1, 2, 3]));
    }

    private static void TestMostFrequentValue()
    {
        AssertEx.Equal(2, ArraysHashing.MostFrequentValue([3, 2, 3, 2, 2]));
        AssertEx.Equal(1, ArraysHashing.MostFrequentValue([2, 1]));
    }

    private static void TestUniqueIntersection()
    {
        AssertEx.SequenceEqual([2], ArraysHashing.UniqueIntersection([1, 2, 2, 1], [2, 2]));
        AssertEx.SequenceEqual([4, 9], ArraysHashing.UniqueIntersection([4, 9, 5], [9, 4, 9, 8, 4]));
    }

    private static void TestUniqueFrequencies()
    {
        AssertEx.True(ArraysHashing.HasUniqueFrequencies([1, 2, 2, 1, 1, 3]));
        AssertEx.False(ArraysHashing.HasUniqueFrequencies([1, 2]));
    }

    private static void TestLongestConsecutive()
    {
        AssertEx.Equal(4, ArraysHashing.LongestConsecutive([100, 4, 200, 1, 3, 2]));
        AssertEx.Equal(0, ArraysHashing.LongestConsecutive([]));
        AssertEx.Equal(3, ArraysHashing.LongestConsecutive([1, 2, 0, 1]));
    }
}
