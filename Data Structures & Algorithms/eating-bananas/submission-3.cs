public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var low = 1;
        var result = 0;
        var high = piles.Max();

        while (low <= high) {
            var mid = (low + high) / 2;

            if (CanDo(piles, mid, h)) {
                result = mid;
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return result;
    }

    public static bool CanDo(int[] piles, int testValue, int h) {
        // So we need to test how many hours the eating will take to complete
        // eating at the test value, a pile cannot take a less than one hour.
        var hours = 0;
        foreach (var pile in piles) {
            hours += ((pile + testValue - 1) / testValue);
            if (hours > h)
                return false;
        }
        return hours <= h;
    }
}

//        var low = 1;
//         var high = int.MaxValue;
//         while (low <= high) {
//             var mid = low + (high - low) / 2;
//             if (guess(mid) == 0) {
//                 return mid;
//             } else if (guess(mid) == -1) {
//                 high = mid - 1;
//             } else {
//                 low = mid + 1;
//             }
//         }
//         return -1;