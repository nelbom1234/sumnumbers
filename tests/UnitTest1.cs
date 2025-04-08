namespace tests;

using NUnit.Framework.Internal;
using sumtal;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestFor()
    {
        int result = new ForSum().CalculateSum(7);
        Assert.That(result == 28);
    }

    [Test]
    public void TestArithmetic() {
        int result = new ArithmeticSum().CalculateSum(10);
        Assert.That(result == 55);
    }

    [Test]
    public void TestForEach() {
        int result = new ForEachSum().CalculateSum(12);
        Assert.That(result == 78);
    }

    [Test]
    public void TestWhile() {
        int result = new WhileSum().CalculateSum(15);
        Assert.That(result == 120);
    }

    [Test]
    public void TestRecursive() {
        int result = new RecursiveSum().CalculateSum(9);
        Assert.That(result == 45);
    }
}
