using System;

namespace Poker
{
    class Program
    {
        public static void Main()
        {
            Console.Write("White: ");
            var white = Console.ReadLine();
            Console.Write("Black: ");
            var black = Console.ReadLine();


            var whiteHandcards = white.Split().ToList();
            var blackHandcards = black.Split().ToList();

            var cardChecker = new CardChecker();
            var result = cardChecker.CheckWhoWin(whiteHandcards, blackHandcards);

            Console.WriteLine($"\n Name : { "Rank".PadRight(15) } : {"2nd step Compare".PadRight(15)} ");
            Console.WriteLine($" White: { cardChecker.whiteRank.ToString().PadRight(15)} : {cardChecker.white2ndCompare.PadRight(15)}");
            Console.WriteLine($" Black: { cardChecker.blackRank.ToString().PadRight(15)} : {cardChecker.black2ndCompare.PadRight(15)}");

            if (result == "Tie")
            {
                Console.WriteLine($" Tie.");
            }
            else if( result == "white" )
            {
                Console.WriteLine($" {result} wins. - with { cardChecker.whiteRank}");
            }
            else if (result == "black")
            {
                Console.WriteLine($" {result} wins. - with { cardChecker.blackRank}");
            }
            else
            {
                Console.WriteLine($"\n Error: {result}");
            }


        }
    }
}
