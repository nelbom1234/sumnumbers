namespace sumtal;

internal class Program {
    static void Main(string[] args) {
        int i = Number.GetNumber();

        ISum summer = new WhileSum();

        int sum = summer.CalculateSum(i);

        System.Console.WriteLine($"Den endelige sum er: {sum}");
    }
}