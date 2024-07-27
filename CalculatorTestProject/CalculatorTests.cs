using Xunit;
namespace GitActionCalculator
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers1()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
        [Fact]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Subtract(5, 3);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ShouldReturnQuotientOfTwoPositiveNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Divide(10, 2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_DivideByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }

        [Fact]
        public void Divide_ShouldReturnNegativeQuotient_WhenDividendIsNegative()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Divide(-10, 2);

            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Divide_ShouldReturnNegativeQuotient_WhenDivisorIsNegative()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Divide(10, -2);

            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Divide_ShouldReturnZero_WhenDividendIsZero()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Divide(0, 2);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_ShouldReturnPositiveQuotient_WhenBothDividendAndDivisorAreNegative()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Divide(-10, -2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_LargeNumbers_ShouldReturnCorrectQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            int largeDividend = int.MaxValue;
            int largeDivisor = int.MaxValue / 2;

            // Act
            int result = calculator.Divide(largeDividend, largeDivisor);

            // Assert
            Assert.Equal(2, result);
        }
    }
}