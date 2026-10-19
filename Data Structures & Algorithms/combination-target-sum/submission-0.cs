public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        // We need move through the array, as in
        var result = new List<List<int>>();
        var current = new List<int>();
        var start = 0;
        GetDistinct(nums, target, result, current, start);
        return result;
    }
    void GetDistinct(int[] nums, int target, List<List<int>> result, List<int> current, int start) {
        if (start == nums.Length) {
            return;
        } else if (current.Sum() == target) {
            result.Add(new List<int>(current));
            return;
        } else if (current.Sum() > target) {
            return;
        }

        current.Add(nums[start]);
        GetDistinct(nums, target, result, current, start);
        current.Remove(nums[start]);
        GetDistinct(nums, target, result, current, start + 1);
    }
}
