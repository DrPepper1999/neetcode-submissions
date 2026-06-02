public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var s = 0;
        var e = numbers.Length - 1;
        var sum = 0;

        while(s < e) {
            sum = numbers[s] + numbers[e];
            if (sum == target) {
                return [s + 1, e + 1];
            }

            if (sum < target) {
                s++;
            }
            else {
                e--;
            }
        }

        return [];
    }
}
