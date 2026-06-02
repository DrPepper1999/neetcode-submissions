public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = GetKey(str);
            if (!groups.TryAdd(key, new List<string> {str})) {
                groups[key].Add(str);
            }
        }

        return groups.Select(x => x.Value).ToList();
    }
    
    private string GetKey(string str) {
        var chars = new int[26];
        foreach (var c in str) {
            chars[c - 'a']++;
        }

        return string.Join(",", chars);
    }
}
