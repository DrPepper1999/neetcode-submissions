public class Solution {
    public int MaxProfit(int[] prices) {
        var l = 0;
        var r = l + 1;
        var profit = 0;

        while (r < prices.Length) {
            profit = Math.Max(profit, prices[r] - prices[l]);

            if (prices[r] < prices[l]) {
                l = r;
            }

            r++;
        }

        return profit;
    }
}
