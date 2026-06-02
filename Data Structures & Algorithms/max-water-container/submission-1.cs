public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
        var r = heights.Length-1;
        var result = 0;

        while(l < r) {
            var s = (r - l) * (Math.Min(heights[l], heights[r]));
            result = Math.Max(result, s);

            if (heights[l] < heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return result;
    }
}
