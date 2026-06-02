public class Solution {
    public int CharacterReplacement(string s, int k) {
          var frequencyCharacter = new Dictionary<char, int>();
        var max = 0;
        var left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (!frequencyCharacter.TryAdd(s[right], 1))
            {
                frequencyCharacter[s[right]] += 1;
            }

            var windowLength = right - left + 1;
            var replaceCount = windowLength - frequencyCharacter.Max(kv => kv.Value);

            if (replaceCount <= k)
            {
                max = Math.Max(max, windowLength);
            }
            else
            {
                frequencyCharacter[s[left]] -= 1;
                left++;
            }
        }

        return max;
    }
}
