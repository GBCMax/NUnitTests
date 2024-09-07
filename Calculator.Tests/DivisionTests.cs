using NUnitTests.Calculator;

namespace CalculatorTests
{
  public class DivisionTests
  {
    private readonly Calculator _calculator = new();

    [Test]
    public void DivisionTest1()
    {
      var firstNumber = 8;
      var secondNumber = 2;

      var result = _calculator.Division(firstNumber, secondNumber);

      var expected = 4;

      Assert.That(expected == result);
    }

    [Test]
    public void DivisionTest2()
    {
      var firstNumber = 15;
      var secondNumber = 4;

      var result = _calculator.Division(firstNumber, secondNumber);

      var expected = 3;

      Assert.That(expected == result);
    }
  }
}
