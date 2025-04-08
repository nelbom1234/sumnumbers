namespace sumtal;

public class ForSum : ISum {
    public int CalculateSum(int tal) {
        int sum = 0;
        for (int i = 1; i <= tal; i++) {
            sum += i;
        }
        return sum;
    }
}