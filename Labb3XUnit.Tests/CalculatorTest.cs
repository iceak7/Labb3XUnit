using System;
using Xunit;

namespace Labb3XUnit.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Division_With_Minus_Return_Minus()
        {
            Calculator calc = new Calculator();

            var actual = calc.Division(10, -2);
            var expected = -5;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(100, 50, 2)]
        [InlineData(25, 2, 12.5)]
        [InlineData(-40, 4, -10)]
        [InlineData(2, 1, 2)]
        public void DivisionTest(double nr1, double nr2, double expectedResult)
        {
            Calculator calc = new Calculator();

            var actual = calc.Division(nr1, nr2);

            Assert.Equal(expectedResult, actual);


        }


        [Fact]
        public void Multiplication_Should_Return_NotEqual()
        {
            Calculator calc = new Calculator();

            var actual = calc.Muliplication(3, 3);
            double shouldNotEqual = 10;

            Assert.False(actual == shouldNotEqual);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(5, 2, 10)]
        [InlineData(-3, 10, -30)]
        [InlineData(2.5, 10, 25)]
        [InlineData(2, 1, 2)]
        public void MultiplicationTest(double nr1, double nr2, double expectedResult)
        {
            Calculator calc = new Calculator();

            var actual = calc.Muliplication(nr1, nr2);

            Assert.Equal(expectedResult, actual);
        }


        [Fact]
        public void Subtraction_50_Minus_10_Return_40()
        {
            Calculator calc = new Calculator();

            var actual = calc.Subtraction(50, 10);
            double expected = 40;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 4, 8)]
        [InlineData(10, 3, 7)]
        [InlineData(20, -10, 30)]
        [InlineData(25.5, 25, 0.5)]
        [InlineData(0, 1, -1)]
        public void SubtractionTest(double nr1, double nr2, double expectedResult)
        {
            Calculator calc = new Calculator();

            var actual = calc.Subtraction(nr1, nr2);

            Assert.Equal(expectedResult, actual);


        }


        [Fact]
        public void Addition_40_Plus_40_Return_80()
        {
            Calculator calc = new Calculator();

            var actual = calc.Addition(40, 40);
            double expected = 80;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 4, 16)]
        [InlineData(50, 51, 101)]
        [InlineData(10, -10, 0)]
        [InlineData(2.5, 2.5, 5)]
        [InlineData(5, -15, -10)]
        public void AdditionTest(double nr1, double nr2, double expectedResult)
        {
            Calculator calc = new Calculator();

            var actual = calc.Addition(nr1, nr2);

            Assert.Equal(expectedResult, actual);


        }
    }
}
