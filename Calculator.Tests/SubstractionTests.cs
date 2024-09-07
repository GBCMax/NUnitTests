using NUnitTests.Calculator;

namespace CalculatorTests
{
  public class SubstractionTests
  {
    private readonly Calculator _calculator = new();

    [Test]
    public void SubstractionTest1()
    {
      var firstNumber = 5;

      var secondNumber = 6;

      var result = _calculator.Subtraction(firstNumber, secondNumber);

      var expected = -1;

      Assert.That(expected == result);
    }

    [Test]
    public void SubstractionTest2()
    {
      var firstNumber = 77;

      var secondNumber = -5;

      var result = _calculator.Subtraction(firstNumber, secondNumber);

      var expected = 82;

      Assert.That(expected == result);
    }
  }
}
