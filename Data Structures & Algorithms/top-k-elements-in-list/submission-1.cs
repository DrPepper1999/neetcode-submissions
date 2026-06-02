public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
  var freq = new List<int>[nums.Length + 1];
        for (var i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        var countNums = CreateCountNums(nums);
        foreach (var tuple in countNums) {
            freq[tuple.Value].Add(tuple.Key);
        }

        var result = new int[k];
        var index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in freq[i]) {
                result[index++] = n;
                if (index == k) {
                    return result;
                }
            }
        }

        return result;
    }

    private Dictionary<int, int> CreateCountNums(int[] nums) {
        var result = new Dictionary<int, int>();

        foreach (var n in nums) {
            if (!result.TryAdd(n, 1)) {
                result[n]++;
            }
        }

        return result;
    }
}
