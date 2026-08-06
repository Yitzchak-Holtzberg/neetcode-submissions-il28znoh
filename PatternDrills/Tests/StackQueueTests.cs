using AlgoPatternDrills.Common;
using AlgoPatternDrills.Patterns;

namespace AlgoPatternDrills.Tests;

public static class StackQueueTests
{
    public static IReadOnlyList<DrillCase> All() =>
    [
        new(1, "Valid parentheses", TestValidParentheses),
        new(2, "Evaluate postfix", TestEvaluatePostfix),
        new(3, "Baseball score", TestBaseballScore),
        new(4, "Remove adjacent duplicates", TestRemoveAdjacentDuplicates),
        new(5, "Next greater value", TestNextGreater),
        new(6, "Students unable to eat", TestStudents),
        new(7, "Sliding-window maximum", TestSlidingWindowMaximum),
        new(8, "Days until warmer", TestDaysUntilWarmer)
    ];

    private static void TestValidParentheses()
    {
        AssertEx.True(StackQueue.IsValidParentheses("()[]{}"));
        AssertEx.True(StackQueue.IsValidParentheses("{[()]}"));
        AssertEx.False(StackQueue.IsValidParentheses("(]"));
        AssertEx.False(StackQueue.IsValidParentheses("([)]"));
    }

    private static void TestEvaluatePostfix()
    {
        AssertEx.Equal(9, StackQueue.EvaluatePostfix(["2", "1", "+", "3", "*"]));
        AssertEx.Equal(6, StackQueue.EvaluatePostfix(["4", "13", "5", "/", "+"]));
    }

    private static void TestBaseballScore()
    {
        AssertEx.Equal(30, StackQueue.BaseballScore(["5", "2", "C", "D", "+"]));
        AssertEx.Equal(27, StackQueue.BaseballScore(["5", "-2", "4", "C", "D", "9", "+", "+"]));
    }

    private static void TestRemoveAdjacentDuplicates()
    {
        AssertEx.Equal("ca", StackQueue.RemoveAdjacentDuplicates("abbaca"));
        AssertEx.Equal("ay", StackQueue.RemoveAdjacentDuplicates("azxxzy"));
    }

    private static void TestNextGreater()
    {
        AssertEx.SequenceEqual([4, 2, 4, -1, -1], StackQueue.NextGreaterToRight([2, 1, 2, 4, 3]));
        AssertEx.SequenceEqual([-1], StackQueue.NextGreaterToRight([7]));
    }

    private static void TestStudents()
    {
        AssertEx.Equal(0, StackQueue.CountStudentsUnable([1, 1, 0, 0], [0, 1, 0, 1]));
        AssertEx.Equal(3, StackQueue.CountStudentsUnable([1, 1, 1, 0, 0, 1], [1, 0, 0, 0, 1, 1]));
    }

    private static void TestSlidingWindowMaximum()
    {
        AssertEx.SequenceEqual([3, 3, 5, 5, 6, 7], StackQueue.SlidingWindowMaximum([1, 3, -1, -3, 5, 3, 6, 7], 3));
        AssertEx.SequenceEqual([1], StackQueue.SlidingWindowMaximum([1], 1));
    }

    private static void TestDaysUntilWarmer()
    {
        AssertEx.SequenceEqual([1, 1, 4, 2, 1, 1, 0, 0], StackQueue.DaysUntilWarmer([73, 74, 75, 71, 69, 72, 76, 73]));
        AssertEx.SequenceEqual([0, 0, 0], StackQueue.DaysUntilWarmer([80, 79, 78]));
    }
}
