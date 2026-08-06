namespace AlgoPatternDrills.Patterns;

public static class BinarySearch
{
    // WORKED SAMPLE
    // Invariant: if target exists, it remains inside [left, right].
    public static int ReferenceExactSearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (nums[middle] == target)
                return middle;

            if (nums[middle] < target)
                left = middle + 1;
            else
                right = middle - 1;
        }

        return -1;
    }

    // 1. Return any index containing target, or -1.
    public static int ExactSearch(int[] nums, int target) =>
        throw new NotImplementedException();

    // 2. Return the first index containing target, or -1.
    public static int FirstOccurrence(int[] nums, int target) =>
        throw new NotImplementedException();

    // 3. Return the last index containing target, or -1.
    public static int LastOccurrence(int[] nums, int target) =>
        throw new NotImplementedException();

    // 4. Return the first index whose value is at least target.
    public static int LowerBound(int[] nums, int target) =>
        throw new NotImplementedException();

    // 5. Return the index at which target exists or should be inserted.
    public static int SearchInsertPosition(int[] nums, int target) =>
        throw new NotImplementedException();

    // 6. Search a row-major sorted matrix.
    public static bool SearchMatrix(int[][] matrix, int target) =>
        throw new NotImplementedException();

    // 7. Return floor(sqrt(number)) without using Math.Sqrt.
    public static int IntegerSquareRoot(int number) =>
        throw new NotImplementedException();

    // 8. Return the minimum integer eating speed that finishes within hours.
    public static int MinimumEatingSpeed(int[] piles, int hours) =>
        throw new NotImplementedException();
}
