namespace sumtal;

class ArithmeticSum : ISum {
    public int CalculateSum(int tal) {
        return (tal * (tal + 1))/2;
    }
}