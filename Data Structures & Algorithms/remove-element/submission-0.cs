public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var currentIndexValue = 0;
        for (var index = 0; index < nums.Length; index++) {
            if (nums[index] != val) {
                nums[currentIndexValue] = nums[index];
                currentIndexValue++;
            }
        }
        return currentIndexValue;
    }
}