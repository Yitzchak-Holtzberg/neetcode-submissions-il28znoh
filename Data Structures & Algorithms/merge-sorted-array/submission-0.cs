public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // N has more slots than numbers, it has the whole first
        //  Half of the numbers to be used are in it,
        //  second half is empty
        var spot1 = m - 1;
        var spot2 = n - 1;

        var write = m + n - 1;

        while (spot2 != -1) {
            if (spot1 > -1 && nums1[spot1] >= nums2[spot2]) {
               nums1[write] = nums1[spot1];
               write--;spot1--;
            }else{
                nums1[write] = nums2[spot2];
                write--;spot2--;
            }
        }
    }
}