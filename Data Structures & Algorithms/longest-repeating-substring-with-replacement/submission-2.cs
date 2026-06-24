public class Solution {
    public int CharacterReplacement(string s, int k) {
        var max = 0;
        var dic = new Dictionary<char, int>();

        var l = 0;
        var r = 0;

        while (r <= s.Length - 1) {
            if (!dic.TryAdd(s[r], 1)) {
                dic[s[r]]++;
            }

             var maxSymbol = dic.MaxBy(x => x.Value).Value;
             var subSLength = r - l + 1;
             var otherSymbols = subSLength - maxSymbol;
             if (otherSymbols <= k) {
                max = Math.Max(max, subSLength);
             }
             else {
                dic[s[l]]--;
                l++;
             }

             r++;
        }

        return max;
    }
}
