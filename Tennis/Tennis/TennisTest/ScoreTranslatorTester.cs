using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tennis;

namespace TennisTest
{
    [TestClass]
    public class ScoreTranslatorTester
    {
        [TestMethod]
        public void TranScore_argIs0_returnLove()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(0);

            Assert.AreEqual(result, "love");
        }

        [TestMethod]
        public void TranScore_argIs1_return15()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(1);

            Assert.AreEqual(result, "15");
        }

        [TestMethod]
        public void TranScore_argIs2_return30()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(2);

            Assert.AreEqual(result, "30");
        }

        [TestMethod]
        public void TranScore_argIs3_return40()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(3);

            Assert.AreEqual(result, "40");
        }

        [TestMethod]
        public void TranScore_argIs4_returnAdvantage()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(4);

            Assert.AreEqual(result, "advantage");
        }

        [TestMethod]
        public void TranScore_argIs5_return5()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(5);

            Assert.AreEqual(result, "5");
        }

        [TestMethod]
        public void TranScore_argIs6_return6()
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(6);

            Assert.AreEqual(result, "6");
        }
    }
}
