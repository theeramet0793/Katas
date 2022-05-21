using PrimeComposite;
using System.Collections.Generic;
using Xunit;

namespace PrimeCompositeXunit
{
    public class PrimeNumberXunitTest
    {
        [Theory]
        [InlineData(10, new int[] {2,3,5,7})]
        [InlineData(100, new int[] { 2, 3, 5, 7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97 })]
        public void FindPrimeNumberFrom_1_To_Max_return_expected_result( int max, int[] expectedResult)
        {
            var primeNumber = new PrimeNumber();

            var result = primeNumber.FindPrimeNumberFrom1To(max);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(7, true)]
        [InlineData(27, false)]
        public void IsPrimeNumber_argIs_num_return_expected_result(int num, bool expectedResult)
        {
            var primeNumber = new PrimeNumber();

            var result = primeNumber.IsPrimeNumber(num);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1,10, new int[] {2,3,5,7})]
        [InlineData(1,20, new int[] { 2, 3, 5, 7 ,11,13,17,19})]
        public void FindPrimeNumberInRange_return_expected_result(int first,int last, int[] expectedResult)
        {
            var primeNumber = new PrimeNumber();

            var result = primeNumber.FindPrimeNumberInRange(first,last);

            Assert.Equal(expectedResult, result);
        }
    }
}