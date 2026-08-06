namespace AlgoPatternDrills.Common;

public static class AssertEx
{
    public static void True(bool actual, string? message = null)
    {
        if (!actual)
            throw new TestFailureException(message ?? "Expected true, received false.");
    }

    public static void False(bool actual, string? message = null)
    {
        if (actual)
            throw new TestFailureException(message ?? "Expected false, received true.");
    }

    public static void Equal<T>(T expected, T actual, string? message = null)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
            throw new TestFailureException(message ?? $"Expected {expected}; received {actual}.");
    }

    public static void SequenceEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, string? message = null)
    {
        T[] expectedArray = expected.ToArray();
        T[] actualArray = actual.ToArray();

        if (!expectedArray.SequenceEqual(actualArray))
        {
            string expectedText = string.Join(", ", expectedArray);
            string actualText = string.Join(", ", actualArray);
            throw new TestFailureException(message ?? $"Expected [{expectedText}]; received [{actualText}].");
        }
    }

    public static void UnorderedEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, string? message = null)
        where T : notnull
    {
        var expectedCounts = expected.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var actualCounts = actual.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        if (expectedCounts.Count != actualCounts.Count ||
            expectedCounts.Any(pair => !actualCounts.TryGetValue(pair.Key, out int count) || count != pair.Value))
        {
            throw new TestFailureException(message ?? "The sequences contain different values.");
        }
    }
}

public sealed class TestFailureException : Exception
{
    public TestFailureException(string message) : base(message)
    {
    }
}
