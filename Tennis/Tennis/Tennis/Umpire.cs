using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Umpire
    {
        // method for 1 game (version 1)
        public void GiveScoreTo(Player player)
        {
             player.score += 1;
        }
        public Player? CheckWhoWinGame(Player player1, Player player2)
        {
                 if(player1.score==4 && player2.score<=2) return player1;
            else if(player1.score==5 && player2.score==3) return player1;
            else if(player1.score<=2 && player2.score==4) return player2;
            else if(player1.score==3 && player2.score==5) return player2;
            else return null;
            
        }
        public bool CheckIsBothAdvantage(Player player1, Player player2)
        { return player1.score==4 && player2.score==4;}
        public bool CheckIsDeuce(Player player1, Player player2)
        {
            if (player1.score == 3 && player2.score == 3)
                return true;
            else
                return false;
        }
        public void SetBackToDeuce(Player player1, Player player2)
        {
            if(player1.score == 4 && player2.score == 4)
            {
                player1.score = player1.score-1;
                player2.score = player2.score-1;
                
            }
        }

        // method for 1 match ( version update )
        public void ResetScoreToZero(Player player1, Player player2)
        {
            player1.score = 0;
            player2.score = 0;
        }
        public void ResetGameToZero(Player player1,Player player2)
        {
            player1.winGame = 0;
            player2.winGame = 0;
        }
        public void ResetMatch(Player player1, Player player2)
        {
            player1.score = 0;
            player2.score = 0;
            player1.winGame = 0;
            player2.winGame = 0;
            player1.winSet = 0;
            player2.winSet = 0;
        }
        public void GiveGameTo(Player player)
        {
            player.winGame += 1;
        }
        public Player? CheckWhoWinSet(Player player1, Player player2)
        {
            if (player1.winGame == 6 && player2.winGame <= 4) return player1;
            else if (player1.winGame == 7 && player2.winGame == 5) return player1;
            else if (player1.winGame <= 4 && player2.winGame == 6) return player2;
            else if (player1.winGame == 5 && player2.winGame == 7) return player2;
            else return null;

        }
        public Player? CheckWhoWinTiebreakSet(Player player1, Player player2)
        {
            if (player1.winGame == 7 && player2.winGame == 6) return player1;
            else if (player1.winGame == 6 && player2.winGame == 7) return player2;
            else return null;
        }
        public void GiveSetTo(Player player)
        {
            player.winSet += 1;
            
        }
        public bool CheckIsTiebreak(Player player1, Player player2)
        {
            if (player1.winGame == 6 && player2.winGame == 6)
                return true;
            else
                return false;
        }
        public Player? CheckTiebreakGameWin(Player player1, Player player2)
        {
            if (player1.score == 7 && player2.score <= 6)
                return player1;
            else if (player1.score <= 6 && player2.score == 7)
                return player2;
            else
                return null;
        }
        public Player? CheckWhoWinMatch(Player player1, Player player2)
        {
            if (player1.winSet == 2 && player2.winSet <= 1) return player1;
            else if (player1.winSet <= 1 && player2.winSet == 2) return player2;
            else return null;
        }
    }
}
