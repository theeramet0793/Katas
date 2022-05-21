using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Tiebreak
    {
        public Player playTiebreak(Player player1, Player player2)
        {
            Random rnd = new Random();
            var winnerRound = new Player();
            while (true)
            {
                if (rnd.Next(1, 3) == 1) return player1 ;
                else return player2;               
            }
        }
    }
}
