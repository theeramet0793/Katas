using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tennis;

namespace TennisTest
{
    [TestClass]
    public class UmpireTest
    {
        [TestMethod]
        public void GiveScoreTo_toPlayerObj1_thatPlayerScoreIncreseByOnePoint()
        {
            var player = new Player();
            player.score = 123;

            var umpire = new Umpire();
            umpire.GiveScoreTo(player);
            var result = player.score;

            Assert.AreEqual(result, 124);
        }

        [TestMethod]
        public void GiveScoreTo_ToPlayerObj2_thatPlayerScoreIncreseByOnePoint()
        {
            var player = new Player();
            player.score = 19;

            var umpire = new Umpire();
            umpire.GiveScoreTo(player);
            var result = player.score;

            Assert.AreNotEqual(result, 19);
        }

        [TestMethod]
        
        public void CheckWhoIsWin_0v0_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v1_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v2_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v3_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 3;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v4_returnPlayer2()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player2);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v5_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_0v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v0_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 0;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v1_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v2_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v3_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 3;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v4_returnPlayer2()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player2);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v5_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_1v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 1;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v0_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 0;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v1_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v2_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v3_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 3;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v4_returnPlayer2()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player2);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v5_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_2v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 2;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v0_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 0;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v1_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v2_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v3_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 0;
            player2.score = 0;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v4_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v5_returnPlayer2()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player2);
        }

        [TestMethod]
        public void CheckWhoIsWin_3v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v0_returnPlayer1()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result,player1);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v1_returnPlayer1()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player1);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v2_returnPlayer1()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player1);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v3_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 3;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v4_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v5_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_4v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v0_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 0;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v1_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 1;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v2_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 2;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v3_returnPlayer1()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 3;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.AreEqual(result, player1);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v4_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v5_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 5;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_5v6_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 5;
            player2.score = 6;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_6v100_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 6;
            player2.score = 1000;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckWhoIsWin_6v4_returnNull()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 6;
            player2.score = 4;

            var result = umpire.CheckWhoIsWin(player1, player2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CheckIsBothAdvantage_BothAreNotAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIsBothAdvantage_BothAreAdv_returnTrue()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;
            player2.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIsBothAdvantage_OnlyPlayer1IsAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIsBothAdvantage_OnlyPlayer2IsAdv_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player2.score = 4;

            var result = umpire.CheckIsBothAdvantage(player1, player2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIsDeuce_itNotDeuce_returnFale()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            var result = umpire.CheckIsDeuce(player1, player2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIsDeuce_itDeuce_returnTrue()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();
            player1.score = 3;
            player2.score = 3;

            var result = umpire.CheckIsDeuce(player1, player2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetBackToDeuce_bothPlayerScoreIs4_BothScoreChangeTo3()
        {
            var player1 = new Player();
            var player2 = new Player();
            var umpire = new Umpire();

            player1.score = 4;
            player2.score = 4;

            umpire.SetBackToDeuce(player1, player2);

            Assert.IsTrue((player1.score == 3) && (player2.score == 3));
        }
    }
}