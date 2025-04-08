namespace sumtal;

public class ForEachSum : ISum {
    public int CalculateSum(int tal) {
        if (tal < 1) {
            return 0;
        }
        int sum = 0;
        var sumList = from number in Enumerable.Range(1, tal) select number;
        foreach (int val in sumList) {
            sum += val;
        }
        return sum;
    }
}