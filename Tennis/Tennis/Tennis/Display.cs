using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Display
    {
        public void showMatchTable(string player1Name, string player2Name,char[] p1,char[] p2)
        {
            Console.WriteLine($"\n\n");
            Console.WriteLine($"+----------+---+---+---+-------+");
            Console.WriteLine($"|   SET    | 1 | 2 | 3 | Total |");
            Console.WriteLine($"+----------+---+---+---+-------+");
            Console.WriteLine($"|  {player1Name}   | {p1[0]}   {p1[1]}   {p1[2]} |       |");
            Console.WriteLine($"+------------------------------+");
            Console.WriteLine($"|  {player2Name}     | {p2[0]}   {p2[1]}   {p2[2]} |       |");
            Console.WriteLine($"+------------------------------+");
        }

        public void showGameTable(Player player1,Player player2)
        {
            Console.WriteLine($"                        +-----------------+                           ");
            Console.WriteLine($"                        | {player1.name}  |   {player2.name}  |                           ");
            Console.WriteLine($"                        +-----------------+                           ");
            Console.WriteLine($"                        |   {player1.winGame}  Games   {player2.winGame}  |                           ");
            Console.WriteLine($"                        +-----------------+                           ");
            Console.WriteLine($"                        |   {player1.winSet}   Set  {player2.winSet}    |                           ");
            Console.WriteLine($"                        +-----------------+                           ");
           
        }

        public void showEachGameHeaderTable(string player1Name, string player2Name,int setCount,int gameCount)
        {
            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine($"                         Set {setCount} : Game {gameCount}                              \n");
            Console.WriteLine($" {"Round".PadRight(15)}{"Win".PadRight(15)}{player1Name.PadRight(15)}{player2Name.PadRight(15)}{"Note".PadRight(15)}\n");
        }

        public void showRestartGame()
        {
            Console.WriteLine($"\n");
            Console.Write($" Press any key to start new game... ");
            Console.ReadKey();
            Console.Clear();
        }

        public void showEachRoundWinner(int round,Player winner)
        {
            Console.Write($" {round.ToString().PadRight(15)}{winner.name.PadRight(15)}");
        }

        public void showEachRoundDetail(Player? winner,Player player1,Player player2, string player1Score,string player2Score,string note)
        {
            if (winner == null)
                Console.WriteLine($"{player1Score.PadRight(15)}{player2Score.PadRight(15)}{note.PadRight(15)}");
            else
            {
                if (winner == player1)
                    Console.WriteLine($"{"win".PadRight(15)}{player2Score.PadRight(15)}{note.PadRight(15)}");
                else if (winner == player2)
                    Console.WriteLine($"{player1Score.PadRight(15)}{"win".PadRight(15)}{note.PadRight(15)}");
                Console.WriteLine($"\n The winner Of this game is {winner.name}");
                Console.WriteLine($"----------------------------------------------------------------------------\n");
            }
        }

        public void showMatchWinner(Player winner)
        {
            Console.WriteLine($"\n                +----------------------------------+");
            Console.WriteLine($"                | The winner of Match is {winner.name.PadRight(10)}|");
            Console.WriteLine($"                +----------------------------------+\n");
        }
        
    } 
}
