namespace sumtal;

public class ArithmeticSum : ISum {
    public int CalculateSum(int tal) {
        if (tal < 1) {
            return 0;
        }
        return (tal * (tal + 1))/2;
    }
}