using NUnitTests.Calculator;

namespace CalculatorTests
{
  public class MultiplicationTests
  {
    private readonly Calculator _calculator = new();

    [Test]
    public void MultiplicationTest1()
    {
      var firstNumber = 5;

      var secondNumber = 6;

      var result = _calculator.Miltiplication(firstNumber, secondNumber);

      var expected = 30;

      Assert.That(expected == result);
    }

    [Test]
    public void MultiplicationTest2()
    {
      var firstNumber = 7;

      var secondNumber = 11;

      var result = _calculator.Miltiplication(firstNumber, secondNumber);

      var expected = 77;

      Assert.That(expected == result);
    }
  }
}
