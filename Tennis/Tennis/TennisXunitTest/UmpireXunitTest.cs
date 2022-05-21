using Tennis;
using Xunit;

namespace TennisXunitTest
{
    public class UmpireXunitTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(0, 3)]
        [InlineData(0, 5)]
        [InlineData(0, 6)]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 3)]
        [InlineData(1, 5)]
        [InlineData(1, 6)]
        [InlineData(2, 0)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(2, 3)]
        [InlineData(2, 5)]
        [InlineData(2, 6)]
        [InlineData(3, 0)]
        [InlineData(3, 1)]
        [InlineData(3, 2)]
        [InlineData(3, 3)]
        [InlineData(3, 4)]
        [InlineData(3, 6)]
        [InlineData(4, 3)]
        [InlineData(4, 4)]
        [InlineData(4, 5)]
        [InlineData(4, 6)]
        [InlineData(5, 0)]
        [InlineData(5, 1)]
        [InlineData(5, 2)]
        [InlineData(5, 4)]
        [InlineData(5, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 0)]
        [InlineData(6, 1)]
        [InlineData(6, 2)]
        [InlineData(6, 3)]
        [InlineData(6, 4)] 
        [InlineData(6, 5)]
        [InlineData(6, 6)]
        public void CheckWhoIsWin_returnNull_IfScore_Player1_And_Player2_Is(int scorePlayer1,int scorePlayer2)
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = scorePlayer1;
            player2.score = scorePlayer2;

            var result = umpire.CheckWhoWinGame(player1, player2);

            Assert.Null(result);
        }

        [Fact]
        public void GiveScoreTo_toPlayer_PlayerScoreIncreseByOnePoint()
        {
            var player = new Player();
            player.score = 123;

            var umpire = new Umpire();
            umpire.GiveScoreTo(player);
            var result = player.score;

            Assert.Equal(124, result);
        }

        [Fact]
        public void CheckIsBothAdvantage_BothAreNotAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.False(result);
        }

        [Fact]
        public void CheckIsBothAdvantage_BothAreAdv_returnTrue()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.True(result);
        }

        [Fact]
        public void CheckIsBothAdvantage_OnlyPlayer1IsAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.False(result);
        }

        [Fact]
        public void CheckIsBothAdvantage_OnlyPlayer2IsAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player2.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.False(result);
        }

        [Fact]
        public void CheckIsDeuce_itNotDeuce_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            var result = umpire.CheckIsDeuce(player1, player2);

            Assert.False(result);
        }

        [Fact]
        public void CheckIsDeuce_itDeuce_returnTrue()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 3;

            var result = umpire.CheckIsDeuce(player1, player2);

            Assert.True(result);
        }

        [Fact]
        public void SetBackToDeuce_bothPlayerScoreIs4_BothScoreChangeTo3()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            player1.score = 4;
            player2.score = 4;

            umpire.SetBackToDeuce(player1, player2);

            Assert.True((player1.score == 3) && (player2.score == 3));
        }
    }
}