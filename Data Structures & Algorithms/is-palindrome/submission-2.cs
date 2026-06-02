public class Solution {
    public bool IsPalindrome(string s) {
        var start = 0;
        var end = s.Length-1;

        var str = s.ToLower();
        while(end > start) {
            if (!char.IsLetterOrDigit(str[start]))
            {
                start++;
                continue;
            }

            if (!char.IsLetterOrDigit(str[end]))
            {
                end--;
                continue;
            }

            if (str[start] != str[end]) {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}
