namespace AlgoPatternDrills.Patterns;

public static class TwoPointers
{
    // WORKED SAMPLE
    // Invariant: everything outside [left, right] has already been checked.
    public static bool ReferencePalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    // 1. Ignore punctuation and casing while checking for a palindrome.
    public static bool IsLoosePalindrome(string text) =>
        throw new NotImplementedException();

    // 2. Reverse the array in place.
    public static void Reverse(char[] chars) =>
        throw new NotImplementedException();

    // 3. Given a sorted array, return one-based indices of a pair summing to target.
    public static int[] PairSumSorted(int[] nums, int target) =>
        throw new NotImplementedException();

    // 4. Move every zero to the end while preserving non-zero order.
    public static void MoveZeros(int[] nums) =>
        throw new NotImplementedException();

    // 5. Remove target in place and return the new logical length.
    public static int RemoveTarget(int[] nums, int target) =>
        throw new NotImplementedException();

    // 6. Return the sorted squares of a nondecreasing array.
    public static int[] SortedSquares(int[] nums) =>
        throw new NotImplementedException();

    // 7. Merge nums2 into nums1 in place. nums1 has m+n slots.
    public static void MergeSorted(int[] nums1, int m, int[] nums2, int n) =>
        throw new NotImplementedException();

    // 8. Sort an array containing only 0, 1 and 2 in one pass.
    public static void SortColours(int[] nums) =>
        throw new NotImplementedException();
}
