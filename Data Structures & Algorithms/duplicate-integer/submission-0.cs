public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numbersToDuplicate = new Dictionary<int, bool>();

        foreach (var num in nums)
        {
            if (!numbersToDuplicate.TryAdd(num, false))
            {
                return true;
            }
        }

        return false;
    }
}
