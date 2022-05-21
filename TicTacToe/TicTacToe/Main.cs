using System;
using TicTacToeNamespace;

namespace TicTacToeMain
{
    public class Program{
        public static void Main()
        {
            while (true)
            {
                string[] Mark = { "X", "O" };
                var ttt = new TicTacToe();
                int round = 1;

                ttt.InitiateCellNumber();
                Console.WriteLine("       \n");
                ttt.showTable();
                while (true)
                {
                    string note = string.Empty;
                    var turn = (round % 2 == 0) ? Mark[1] : Mark[0];
                    Console.WriteLine($"\n       Turn : {turn}");
                    Console.Write($"       Enter cell number: ");
                    var input = Console.ReadLine();

                    if (int.TryParse(input, out int takenCell) && takenCell < 10 && takenCell > 0)
                    {
                        var mark = (round % 2 == 0) ? Mark[1] : Mark[0];
                        if (ttt.TakenAtCell(takenCell, mark)) round++;
                        else note = "Select empty cell";
                    }
                    else
                    {
                        note = "Input number 1 - 9 ";
                    }
                    
                    Console.Clear();
                    Console.WriteLine($"\n       {note}");
                    ttt.showTable();
                    var winner = ttt.CheckWinner();
                    if (winner != null)
                    {
                        Console.WriteLine($"\n        The winner is {winner}");
                        break;
                    }
                    else if( ttt.IsFullTable())
                    {
                        Console.WriteLine($"\n        Draw");
                        break;
                    }
                }
                Console.Write("\n        Press any key to start again...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}

