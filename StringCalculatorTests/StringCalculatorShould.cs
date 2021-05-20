using System;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorShould
    {
        [Fact]
        public void GetStringCount()
        {
            var stringCalculator = new StringCalculator();
            var stringCount = stringCalculator.GetStringCount("");

            Assert.Equal(0, stringCount);
        }
    }
}