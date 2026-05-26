public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var newOne = nums;
        var ans = nums.Concat(newOne);
        return ans.ToArray();
    }
}