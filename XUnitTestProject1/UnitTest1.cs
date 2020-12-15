using System;
using UnitTesting;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 32, "f")]
        [InlineData(20, 68, "f")]
        [InlineData(212, 100, "c")]
        [InlineData(-40, -40, "c")]
        public void ConverTemp_ToF_OrC(double expected, double temp, string unit)
        {
            var sut = new TempConverter();
            var actual = sut.TempConvert(temp, unit);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Fizz", 9)]
        [InlineData("FizzBuzz", 15)]
        [InlineData("Baz", 71)]
        [InlineData("Buzz", 10)]
        public void BizzBuzzTest(string expected, int i)
        {
            var actual = FizzBuzzBaz.TestingSomething(i);
            Assert.Equal(expected, actual);

        }
    }

    
}
