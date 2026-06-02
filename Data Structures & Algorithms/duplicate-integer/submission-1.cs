public class Solution {
    public bool hasDuplicate(int[] nums) {
      var uniqueNumbers = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!uniqueNumbers.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}
