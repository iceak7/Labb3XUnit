using System;
using Xunit;
using System.Collections.Generic;

namespace Labb3XUnit.Tests
{
    public class ApplicationTest
    {

        [Theory]
        [InlineData("7", 7)]
        [InlineData("2,5", 2.5)]
        [InlineData("", null)]
        [InlineData("hello", null)]
        [InlineData("-10", -10)]
        public void ValidateNumberTest(string value, double? expectedResult)
        {
            Application app = new Application();

            var actual = app.ValidateNumber(value);

            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData("5", "10", 5, 10)]
        [InlineData("5", "-", 5, null)]
        [InlineData("test", "hello", null, null)]
        [InlineData("10", "15", 10, 15)]
        [InlineData("!", "?", null, null)]
        public void GetNumbersTest(string input1, string input2, double? expectedVal1, double? expectedVal2)
        {
            Application app = new Application();

            List<double?> expected = new List<double?>();
            expected.Add(expectedVal1);
            expected.Add(expectedVal2);
            var actual = app.GetNumbers(input1, input2);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, "adderat", 5, 5, "\nRESULTAT\n5 adderat med 5 är lika med 10.\n")]
        [InlineData(3, "dividerat", 15, 5, "\nRESULTAT\n15 dividerat med 5 är lika med 3.\n")]
        [InlineData(14, "subtraherat", 17, 3, "\nRESULTAT\n17 subtraherat med 3 är lika med 14.\n")]
        [InlineData(9, "multiplicerat", 3, 3, "\nRESULTAT\n3 multiplicerat med 3 är lika med 9.\n")]
        [InlineData(16, "multiplicerat", 4, 4, "\nRESULTAT\n4 multiplicerat med 4 är lika med 16.\n")]
        public void GetResultStringTest(double calculatorResult, string method, double nr1, double nr2, string expectedResult)
        {
            Application app = new Application();

            string actual = app.GetResultString(calculatorResult, method, nr1, nr2);

            Assert.Equal(expectedResult, actual);
        }
    }
}
