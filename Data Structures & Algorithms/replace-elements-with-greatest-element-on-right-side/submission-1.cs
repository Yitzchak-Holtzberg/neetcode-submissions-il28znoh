public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var currentGreatestValue = -1;
        for (var index = arr.Length - 1; index >= 0; index--) {
            var current = arr[index];
            arr[index] = currentGreatestValue;
            currentGreatestValue = Math.Max(currentGreatestValue, current);
        }
        return arr;
    }
}