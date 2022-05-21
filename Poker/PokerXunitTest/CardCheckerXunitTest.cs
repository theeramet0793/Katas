using Poker;
using System.Collections.Generic;
using Xunit;

namespace PokerXunitTest
{
    public class CardCheckerXunitTest
    {
        [Theory]
        [InlineData(new string[] { "2C", "3H", "4S", "8C", "AH", }, new string[] { "2H", "3D", "5S", "9C", "KD", }, "white")]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KD", }, new string[] { "2C", "2D", "3H", "3S", "3D", }, "black")]
        [InlineData(new string[] { "2S", "5D", "3C", "9H", "KD", }, new string[] { "2C", "5S", "3D", "9S", "KS", }, "Tie")]
        public void CheckWhoWin_3Arg_are_whiteCards_blackCards_winner(string[] whiteCards, string[] blackCard, string expecWinner)
        {
            var cardsWhite = new List<string> (whiteCards);
            var cardsBlack = new List<string> (blackCard);
            var cardchecker = new CardChecker();

            var winner = cardchecker.CheckWhoWin(cardsWhite, cardsBlack);
            Assert.Equal(expecWinner, winner.ToString());
        }

        [Theory]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KD", }, new string[] { "2S", "5D", "3C", "9S", "QD", }, false)]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KD", }, new string[] { "2D", "2H", "3S", "3S", "3D", }, false)]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KA", }, new string[] { "2D", "2H", "3S", "3S", "3Z", }, false)]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KD", "KS", }, new string[] { "2D", "2H", "3S", "3S", "3D", }, false)]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", }, new string[] { "2D", "2H", "3S", "3S", "3D", }, false)]

        public void IsCardsCorrect_3Arg_are_BlackCards_WhiteCards_expecResult(string[] whiteCards, string[] blackCard, bool expecResult)
        {
            var cardsWhite = new List<string>(whiteCards);
            var cardsBlack = new List<string>(blackCard);
            var cardchecker = new CardChecker();

            var result = cardchecker.IsCardCorrect(cardsWhite, cardsBlack);
            Assert.Equal(expecResult, result);
        }
    }
}
