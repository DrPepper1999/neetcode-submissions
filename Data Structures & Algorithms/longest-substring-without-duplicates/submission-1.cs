public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var l = 0;
        var r = 0;
        var maxLength = 0;
        var symbols = new HashSet<char>();

        for (; r < s.Length; r++) {
             if (symbols.Add(s[r])) {
                maxLength = Math.Max(maxLength, r - l + 1);
                continue;
            }
            
            while (symbols.Contains(s[r])) {
                symbols.Remove(s[l]);
                l++;
            }
            symbols.Add(s[r]);
        }

    
        return maxLength;
    }
}
