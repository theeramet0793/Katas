using FizzBuzzNamespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        [TestMethod]
        public void FizzOrBuzz_ParamIs0_returnNotInRange()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(0);

            Assert.AreEqual("number not in range", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIsNeg1_returnNotInRange()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(-1);

            Assert.AreEqual("number not in range", result);
        }


        [TestMethod]
        public void FizzOrBuzz_ParamIs1_return1AsString()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs3_returnFizz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(3);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs5_returnBuzz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs10_returnBuzz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(10);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs15_returnFizzBuzz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(15);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs100_returnBuzz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(100);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIs101_returnNotInRange()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz(101);

            Assert.AreEqual("number not in range", result);
        }

        [TestMethod]
        public void FizzOrBuzz_ParamIsNull_returnNull()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz((string)null);

            Assert.AreEqual("null", result);
        }

        [TestMethod]
        public void FizzOrBuzzStringVersion_ParamIsText_returnYoumust()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz("sdtfdsgfg");

            Assert.AreEqual("you must only enter integer", result);
        }

        [TestMethod]
        public void FizzOrBuzzStringVersion_ParamIs15AsString_returnFizzBuzz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz("15");

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzOrBuzzStringVersion_ParamIs9AsString_returnFizz()
        {
            var fb = new FizzBuzz();

            var result = fb.FizzOrBuzz("9");

            Assert.AreEqual("Fizz", result);
        }
    }
}