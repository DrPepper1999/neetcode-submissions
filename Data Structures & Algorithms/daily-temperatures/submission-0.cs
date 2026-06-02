public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
         var stack = new Stack<(int temperature, int index)>();
        var result = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++)
        {
            var temperature = temperatures[i];
            while (stack.Count > 0 && stack.Peek().temperature < temperature)
            {
                var pair = stack.Pop();

                result[pair.index] = i - pair.index;
            }
            
            stack.Push((temperature, i));
        }

        return result;
    }
}
