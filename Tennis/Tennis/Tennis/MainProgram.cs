using System;
using Tennis;

namespace tennisMain;
class MainProgram
{
    public static void Main(string[] arg)
    {
        ScoreTranslator scrTrans = new ScoreTranslator();
        Umpire umpire = new Umpire();
        Player player1 = new Player();
        Player player2 = new Player();
        Display display = new Display();

        player1.name = "Alice";
        player2.name = "Bob";
        int setCount = 1;
        int gameCount = 1;
        

        while (true)
        {
            display.showEachGameHeaderTable(player1.name,player2.name,setCount,gameCount);

            
            int iterator = 1;
            while (true)
            {           
                var winnerOfGame = new Player();
                var winnerOfSet = new Player();
                string player1Score = string.Empty;
                string player2Score = string.Empty;
                string note = string.Empty;
                var winnerOfRound = ControlPlay(player1, player2, gameCount);
                //var winnerOfRound = Play(player1, player2);
                bool isTiebreak = umpire.CheckIsTiebreak(player1, player2);
                umpire.GiveScoreTo(winnerOfRound);               
                
                
                display.showEachRoundWinner(iterator, winnerOfRound);

                if ( isTiebreak ) 
                {
                    winnerOfGame = umpire.CheckTiebreakGameWin(player1, player2);
                    player1Score = player1.score.ToString();
                    player2Score = player2.score.ToString();
                } 
                else
                {
                    if (umpire.CheckIsDeuce(player1, player2)) note = "Deuce";
                    if (umpire.CheckIsBothAdvantage(player1, player2))
                    {
                        umpire.SetBackToDeuce(player1, player2);
                        note = "Set back to deuce";
                    }
                    winnerOfGame = umpire.CheckWhoWinGame(player1, player2);
                    player1Score = scrTrans.TransScore(player1.score);
                    player2Score = scrTrans.TransScore(player2.score);

                }                
                
                display.showEachRoundDetail(winnerOfGame, player1, player2, player1Score, player2Score,note);                
                
                if (winnerOfGame != null)
                {
                    umpire.ResetScoreToZero(player1,player2);
                    umpire.GiveGameTo(winnerOfGame);
                    gameCount += 1;

                    

                    if( isTiebreak ) winnerOfSet = umpire.CheckWhoWinTiebreakSet(player1, player2);
                    else winnerOfSet = umpire.CheckWhoWinSet(player1, player2);
                    if ( winnerOfSet != null)
                    {
                        umpire.GiveSetTo(winnerOfSet);
                        setCount += 1;
                        gameCount = 1;
                    }
                    
                    var winnerOfMatch = umpire.CheckWhoWinMatch(player1, player2);
                    if( winnerOfMatch != null)
                    {
                        setCount = 1;
                        gameCount = 1;
                    }

                    display.showGameTable(player1, player2);

                    if (winnerOfSet != null) umpire.ResetGameToZero(player1, player2);
                    if (winnerOfMatch != null)
                    {
                        umpire.ResetMatch(player1, player2);
                        display.showMatchWinner(winnerOfMatch);
                    }
                    break;
                }
                iterator += 1;
            }
           display.showRestartGame();   
        }
    }

    public static Player Play(Player p1, Player p2)
    {
        Random rnd = new Random();
        if (rnd.Next(1, 3) == 1) return p1;
        else return p2;
    }

    public static Player ControlPlay(Player p1, Player p2,int gameCount)
    {
        int[] fixResult = new int[]{ 1,2,1,2,1,2,1,2,1,2,1,2};

        if(gameCount == 13) return Play(p1, p2);

        if (fixResult[gameCount-1] == 1) 
            return p1;
        else 
            return p2;
    }

}
