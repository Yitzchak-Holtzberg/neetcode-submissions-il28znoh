public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var current = 0;
        var max = 0;
        foreach (var num in nums) {
            if (num == 1) {
                current++;
            } else {
                if (current >= max) {
                    max = current;
                }
                current = 0;
            }
        }
        return Math.Max(current, max);
    }
}