using Tennis;
using Xunit;

namespace TennisXunitTest
{
    public class ScoreTranslatorXunitTest
    {
        [Theory]
        [InlineData(0, "love")]
        [InlineData(1, "15")]
        [InlineData(2, "30")]
        [InlineData(3, "40")]
        [InlineData(4, "advantage")]
        [InlineData(5, "5")]
        [InlineData(6, "6")]
        [InlineData(771, "771")]
        public void TranScore_returnDesiredResult_IfArgIsnum(int num, string desiredResult)
        {
            ScoreTranslator translator = new ScoreTranslator();

            var result = translator.TransScore(num);

            Assert.Equal(desiredResult, result);
        }
    }
}
