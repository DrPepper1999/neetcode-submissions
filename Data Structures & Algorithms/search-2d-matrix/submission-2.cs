public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var l = 0;
        var r = matrix.Length * matrix[0].Length - 1;
        var row = matrix.Length;
        var col = matrix[0].Length;

        while (l <= r) {
            var mid = ((r - l) / 2) + l;
            var value = matrix[mid / col][mid % col];
            if (value == target) {
                return true;
            }

            if (value < target) {
                l = mid + 1;
            }

            if (value > target) {
                r = mid - 1;
            }
        }

        return false;
    }
}
