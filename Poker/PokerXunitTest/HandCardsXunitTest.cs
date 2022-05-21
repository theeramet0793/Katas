using Poker;
using System.Collections.Generic;
using Xunit;

namespace PokerXunitTest
{
    public class HandCardsXunitTest
    {
        [Theory]
        [InlineData(new string[] { "2S", "5D", "3C", "9S", "KD", }, "Highcard")]
        [InlineData(new string[] { "2S", "2D", "3C", "9S", "KD", }, "Pair"    )]
        [InlineData(new string[] { "2S", "2D", "3C", "3S", "KD", }, "TwoPair")]
        [InlineData(new string[] { "2S", "2D", "2C", "9S", "KD", }, "ThreeOfAKind")]
        [InlineData(new string[] { "2S", "3D", "4C", "5S", "6D", }, "Straight")]
        [InlineData(new string[] { "2S", "7S", "3S", "9S", "KS", }, "Flush")]
        [InlineData(new string[] { "2S", "2D", "3C", "3S", "3D", }, "Fullhouse")]
        [InlineData(new string[] { "5S", "5D", "5C", "5H", "KD", }, "FourOfAKind")]
        [InlineData(new string[] { "TS", "JS", "QS", "KS", "AS", }, "StraightFlush")]
        public void CheckRank_2Arg_are_fiveCards_and_expecRank(string[] fiveCards, string expecRank)
        {
            var fiveCard = new List<string> (fiveCards);
            var handcard = new HandCards();
            var rank = handcard.CheckRank( fiveCard );
            Assert.Equal( expecRank, rank.ToString() );
        }
    }
}