using NUnitTests.Calculator;

namespace CalculatorTests
{
  public class AdditionalTests
  {
    private readonly Calculator _calculator = new();

    [Test]
    public void AdditionalTest1()
    {
      var firstNumber = 17;

      var secondNumber = 21;

      var result = _calculator.Additional(firstNumber, secondNumber);

      var expected = 38;

      Assert.That(expected == result);
    }

    [Test]
    public void AdditionalTest2()
    {
      var firstNumber = 76;

      var secondNumber = 44;

      var result = _calculator.Additional(firstNumber, secondNumber);

      var expected = 120;

      Assert.That(expected == result);
    }
  }
}
