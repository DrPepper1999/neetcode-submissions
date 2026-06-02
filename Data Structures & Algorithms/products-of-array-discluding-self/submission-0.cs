public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      if (nums.Length <= 1) {
            return nums;
        }

        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];

        prefix[0] = nums[0];
        postfix[nums.Length-1] = nums[nums.Length-1];
        
        for (var i = 1; i < nums.Length; i++) {
            prefix[i] = nums[i] * prefix[i-1];
        }

        for (var i = nums.Length-2; i >= 0; i--) {
            postfix[i] = nums[i] * postfix[i+1];
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++) {
            result[i] = (i == 0 ? 1 : prefix[i-1]) * (i == nums.Length-1 ? 1 : postfix[i+1]);
        }

        return result;
    }
}
