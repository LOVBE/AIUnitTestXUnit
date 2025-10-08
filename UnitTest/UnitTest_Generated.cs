using System;
using Xunit;

namespace DemoUnitTest_ConsoleApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-5, 5, 0)]
        [InlineData(int.MaxValue, 0, int.MaxValue)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-10, -5, -5)]
        [InlineData(int.MinValue, 1, int.MinValue + 1)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(-3, 6, -18)]
        [InlineData(int.MaxValue / 2, 2, int.MaxValue)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-9, -3, 3)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        public void Divide_ReturnsCorrectQuotient_WhenDivisorNonZero(int a, int b, int expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDivisorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Theory]
        [InlineData(10, 3, 1)]
        [InlineData(-7, -4, -3)]
        [InlineData(int.MaxValue, 1, 0)]
        public void Modulo_ReturnsCorrectRemainder_WhenDivisorNonZero(int a, int b, int expected)
        {
            var result = _calculator.Modulo(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Modulo_ThrowsDivideByZeroException_WhenDivisorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Modulo(10, 0));
        }
    }
}