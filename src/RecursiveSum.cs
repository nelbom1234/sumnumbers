namespace sumtal;

public class RecursiveSum : ISum {
    public int CalculateSum(int tal) {
        if (tal < 1) {
            return 0;
        }
        return tal + CalculateSum(tal-1);
    }
}