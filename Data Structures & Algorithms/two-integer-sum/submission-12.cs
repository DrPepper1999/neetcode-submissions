public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var diffMap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (diffMap.TryGetValue(diff, out var j)) {
                return new int[] {j, i};
            }

            diffMap[nums[i]] = i;
        }

        return new int[0];
    }
}
