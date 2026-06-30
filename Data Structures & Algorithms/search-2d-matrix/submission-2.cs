public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (var row in matrix) {
            var left = 0;
            var right = row.Length - 1;

            while (left <= right) {
                var mid = (left + right) / 2;
                if (row[mid] == target) {
                    return true;
                } else if (row[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
        }
        return false;
    }
}
