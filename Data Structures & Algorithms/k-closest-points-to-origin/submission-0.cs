public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        return QuickSort(points, 0, points.Length - 1)[..k];
    }

    public static int Distance(int[] ints) => (ints[0] * ints[0]) + (ints[1] * ints[1]);

    public static void Swap(int[][] points, int a, int b) => (points[b], points[a]) = (points[a],
                                                                                       points[b]);

    public static int[][] QuickSort(int[][] ints, int startIndex, int endIndex) {
        if (startIndex >= endIndex) {
            return ints;
        }
        var left = startIndex;
        var pivotVal = Distance(ints[endIndex]);

        for (int i = startIndex; i < endIndex; i++) {
            if (Distance(ints[i]) < pivotVal) {
                Swap(ints, left, i);
                left++;
            }
        }
        (ints[left], ints[endIndex]) = (ints[endIndex], ints[left]);

        QuickSort(ints, startIndex, left - 1);

        QuickSort(ints, left + 1, endIndex);

        return ints;
    }
}
