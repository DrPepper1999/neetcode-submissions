public class Solution {
    public bool IsAnagram(string s, string t) {
        var sDic = CreateDic(s);
        var tDic = CreateDic(t);

        if (sDic.Count != tDic.Count) {
            return false;
        }

        return sDic.All(tuple =>
        {
            if (tDic.TryGetValue(tuple.Key, out var value))
            {
                return value == tuple.Value;
            }

            return false;
        });
    }

    private Dictionary<char, int> CreateDic(string str) {
        var result = new Dictionary<char, int>();

        foreach (var c in str) {
            if (!result.TryAdd(c, 1)) {
                result[c]++;
            }
        }

        return result;
    }
}
