public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r) {
            var m = (l + r) / 2;

            if (target == nums[m]) {
                return m;
            }

            if (nums[l] <= nums[m]) {
                if (target < nums[l] || target > nums[m]) {
                    l = m + 1;
                }
                else {
                    r = m - 1;
                }
            }
            else {
                if (target > nums[r] || target < nums[m]) {
                    r = m -1;
                }
                else {
                    l = m + 1;
                }
            }
        }

        return -1;
    }
}
