public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var currL = new List<int>();
        var i = 0;
        AllTheSets(nums, result, i, currL);
        return result;
    }

    public void AllTheSets(int[] nums, List<List<int>> result, int i, List<int> currL) {
        if (i == nums.Length) {
            result.Add(new List<int>(currL));
            return;
        }
        currL.Add(nums[i]);
        AllTheSets(nums, result, i + 1, currL);
        currL.Remove(nums[i]);
        AllTheSets(nums, result, i + 1, currL);
    }
}
