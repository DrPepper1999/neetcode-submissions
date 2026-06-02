public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l = 1;
        var r = piles.Max();

        var result = r;

        while (l <= r) {
            var mid = (r + l) / 2;
            var totalTime = 0;
            foreach (var p in piles) {
                totalTime += (int)Math.Ceiling((double)p / mid);
            }

            if (totalTime > h) {
                l = mid + 1;
            }
            else {
                result = mid;
                r = mid - 1;
            }
        }

        return result;
    }
}
