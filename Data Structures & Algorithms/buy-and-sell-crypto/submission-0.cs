public class Solution {
    public int MaxProfit(int[] prices) {
         var start = 0;
        var maxSellesPrice = 0;
        for (var end = 1; end < prices.Length; end++)
        {
            var sellesPrice = prices[end] - prices[start];

            if (sellesPrice > maxSellesPrice)
            {
                maxSellesPrice = sellesPrice;
            }

            if (prices[end] < prices[start])
            {
                start = end;
            }
        }

        return maxSellesPrice;
    }
}
