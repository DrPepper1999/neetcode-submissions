public class Solution {
    public int LengthOfLongestSubstring(string s) {
 var symbols = new HashSet<char>();
        var maxSubstring = 0;
        var left = 0;
        
        for (var right = 0; right < s.Length; right++)
        {
            if (symbols.Contains(s[right]))
            {
                while (symbols.Contains(s[right]))
                {
                    symbols.Remove(s[left]);
                    left++;
                }
            }
            
            symbols.Add(s[right]);
            maxSubstring = Math.Max(maxSubstring, right - left + 1);
        }

        return maxSubstring;
    }
}
