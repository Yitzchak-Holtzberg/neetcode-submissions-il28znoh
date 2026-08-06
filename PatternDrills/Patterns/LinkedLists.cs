using AlgoPatternDrills.Common;

namespace AlgoPatternDrills.Patterns;

public static class LinkedLists
{
    // WORKED SAMPLE
    // Save next before overwriting current.Next.
    public static ListNode? ReferenceReverse(ListNode? head)
    {
        ListNode? previous = null;
        ListNode? current = head;

        while (current is not null)
        {
            ListNode? next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }

    // 1. Reverse a singly linked list.
    public static ListNode? Reverse(ListNode? head) =>
        throw new NotImplementedException();

    // 2. Merge two sorted lists by relinking existing nodes.
    public static ListNode? MergeSorted(ListNode? first, ListNode? second) =>
        throw new NotImplementedException();

    // 3. Return the middle node. For even length, return the second middle.
    public static ListNode? Middle(ListNode? head) =>
        throw new NotImplementedException();

    // 4. Detect whether the list contains a cycle.
    public static bool HasCycle(ListNode? head) =>
        throw new NotImplementedException();

    // 5. Remove the nth node from the end.
    public static ListNode? RemoveNthFromEnd(ListNode? head, int n) =>
        throw new NotImplementedException();

    // 6. Remove duplicates from a sorted list.
    public static ListNode? DeleteSortedDuplicates(ListNode? head) =>
        throw new NotImplementedException();

    // 7. Return true when the values form a palindrome.
    public static bool IsPalindrome(ListNode? head) =>
        throw new NotImplementedException();

    // 8. Reorder L0→L1→...→Ln into L0→Ln→L1→Ln-1→...
    public static void Reorder(ListNode? head) =>
        throw new NotImplementedException();
}
