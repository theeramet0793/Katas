using Tennis;
using Xunit;

namespace TennisXunitTest
{
    public class UmpireXUnitTestV2
    {

        [Fact]
        public void ResetScoreToZero_both_Player_Score_reset_To_Zero()
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.score = 10;
            player2.score = 10;

            umpire.ResetScoreToZero(player1, player2);
            
            Assert.True(player1.score == 0 && player2.score == 0);
        }

        [Fact]
        public void ResetGameToZero_both_Player_winGame_reset_To_Zero()
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.winGame = 10;
            player2.winGame = 10;

            umpire.ResetGameToZero(player1, player2);

            Assert.True(player1.winGame == 0 && player2.winGame == 0);
        }

        [Fact]
        public void ResetMatch_both_Player_reset_all_To_Zero()
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.winGame = 10;
            player2.winGame = 10;
            player1.winSet = 10;
            player2.winSet = 10;
            player1.score = 10;
            player2.score = 10;

            umpire.ResetMatch(player1, player2);

            var gameCheck = player1.winGame == 0 && player2.winGame == 0;
            var setCheck = player1.winSet == 0 && player2.winSet == 0;
            var scoreCheck = player1.score == 0 && player2.score == 0;

            Assert.True(gameCheck && setCheck && scoreCheck);
        }

        [Fact]
        public void GiveGameTo_player_winGame_increase_by_1()
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();

            umpire.GiveGameTo(player1);
            umpire.GiveGameTo(player2);

            Assert.True(player1.winGame == 1 && player2.winGame == 1);
        }

        [Fact]
        public void GiveSetTo_player_winSet_increase_by_1()
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();

            umpire.GiveSetTo(player1);
            umpire.GiveSetTo(player2);

            Assert.True(player1.winSet == 1 && player2.winSet == 1);
        }

        [Theory]
        [InlineData(true, 6, 6)]
        [InlineData(false, 5, 6)]
        [InlineData(false, 6, 5)]
        [InlineData(false, -1, 5)]
        [InlineData(false, 5, 5)]
        public void CheckIsTieBreak_arg_is_expectedResult_and_inputNumberOfwinGame(bool expectedResult,int p1winGame,int p2winGame)
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.winGame = p1winGame;
            player2.winGame = p2winGame;

            var result = umpire.CheckIsTiebreak(player1,player2);

            Assert.Equal(expectedResult,result);
        }

        [Theory]
        [InlineData(6, 4)]
        [InlineData(6, 3)]
        [InlineData(6, 2)]
        [InlineData(6, 1)]
        [InlineData(6, 0)]
        [InlineData(7, 5)]
        public void CheckWhoWinSet_player1_win_arg_is_winGame_of_player1_and_player2(int p1winGame,int p2winGame)
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();

            player1.winGame = p1winGame;
            player2.winGame = p2winGame;

            var result = umpire.CheckWhoWinSet(player1,player2);

            Assert.Equal(player1, result);
        }

        [Theory]
        [InlineData(6, 7)]
        public void CheckWhoWinTiebreakSet_player2_win(int p1winGame,int p2winGame)
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.winGame = p1winGame;
            player2.winGame = p2winGame;

            var result = umpire.CheckWhoWinTiebreakSet(player1,player2);

            Assert.Equal(player2,result);
        }
        
        [Theory]
        [InlineData(7, 0)]
        [InlineData(7, 3)]
        [InlineData(7, 6)]
        public void CheckTiebreakGameWin_player1_win(int p1Score, int p2Score)
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.score = p1Score;
            player2.score = p2Score;

            var result = umpire.CheckTiebreakGameWin(player1, player2);

            Assert.Equal(player1, result);
        }

        [Theory]
        [InlineData(2, 0)]
        [InlineData(2, 1)]
        public void CheckWhoWinMatch_player1_win(int p1Set, int p2Set)
        {
            var umpire = new Umpire();
            var player1 = new Player();
            var player2 = new Player();
            player1.winSet = p1Set;
            player2.winSet = p2Set;

            var result = umpire.CheckWhoWinMatch(player1, player2);

            Assert.Equal(player1, result);
        }
    }
}
