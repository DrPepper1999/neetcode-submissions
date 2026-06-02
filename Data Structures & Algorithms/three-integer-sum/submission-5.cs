public class Solution {
    public  List<List<int>> ThreeSum(int[] nums) {
        var sortNums = nums.Order().ToArray();

        var result = new List<List<int>>();

        for (var i = 0; i < sortNums.Length; i++) {
            var l = i + 1;
            var r = sortNums.Length - 1;
            
            if (sortNums[i] > 0) {
                break;
            }

            if (i != 0 && sortNums[i] == sortNums[i-1]) {
                continue;
            }

            while (l < r) {
                var sum = sortNums[i] + sortNums[l] + sortNums[r];

                if (sum == 0) {
                    result.Add([sortNums[i], sortNums[l], sortNums[r]]);
                    l++;
                    r--;

                    while (l < r && sortNums[l] == sortNums[l - 1]) {
                        l++;
                    }
                    
                } else if (sum < 0) {
                    l++;
                }
                else {
                    r--;
                }
            }
        }

        return result;
    }
}
