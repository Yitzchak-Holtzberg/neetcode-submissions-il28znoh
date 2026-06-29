public class Solution {
    public void SortColors(int[] nums) {
        int[] valueCount = new int[3];

        foreach (var num in nums) {
            valueCount[num]++;
        }

        var index = 0;
        for (int curr = 0; curr < valueCount.Length; curr++) {
            var inPlace = 0;
            while (inPlace < valueCount[curr]) {
                nums[index] = curr;
                index++;
                inPlace++;
            }
        }
    }
}