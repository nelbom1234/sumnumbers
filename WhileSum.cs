namespace sumtal;

class WhileSum : ISum {
    public int CalculateSum(int tal) {
        int i = tal;
        int sum = 0;
        while (i > 0) {
            sum += i--;
        }
        return sum;
    }
}