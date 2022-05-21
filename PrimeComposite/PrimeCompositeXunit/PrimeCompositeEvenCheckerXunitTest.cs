using PrimeComposite;
using System.Collections.Generic;
using Xunit;

namespace PrimeCompositeXunit
{
    public class PrimeCompositeEvenCheckerXunitTest
    {
        [Theory]
        [InlineData(1,"composite")]
        [InlineData(2, "prime")]
        [InlineData(3, "prime")]
        [InlineData(4, "4")]
        [InlineData(97, "prime")]
        [InlineData(-7, "-7")]
        public void Check(int num, string expectedResult)
        {
            var checker = new PrimeCompositeEvenChecker();

            var result = checker.Check(num);

            Assert.Equal(expectedResult, result);
        }
    }
}
