namespace sumtal;

public class ForEachSum : ISum {
    public int CalculateSum(int tal) {
        int sum = 0;
        var sumList = from number in Enumerable.Range(1, tal) select number;
        foreach (int val in sumList) {
            sum += val;
        }
        return sum;
    }
}