public class Solution {
    public int CharacterReplacement(string s, int k) {
 var frequencyCharacter = new Dictionary<char, int>();
        var result = 0;
        var left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (!frequencyCharacter.TryAdd(s[right], 1))
            {
                frequencyCharacter[s[right]] += 1;
            }

            while (GetReplaceCount(left, right, frequencyCharacter) > k)
            {
                frequencyCharacter[s[left]]--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }

        private static int GetReplaceCount(int left, int right, Dictionary<char, int> frequencyCharacter)
        => (right - left + 1) - frequencyCharacter.Max(kv => kv.Value);
}
