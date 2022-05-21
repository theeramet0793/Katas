using static Poker.Enum;

namespace Poker
{
    public class CardChecker
    {
        public PokerRank whiteRank { get; private set; }
        public PokerRank blackRank { get; private set; }
        public string white2ndCompare { get; private set; } = string.Empty;
        public string black2ndCompare { get; private set; } = string.Empty;
        public string CheckWhoWin(List<string> white, List<string> black)
        {
            if( ! IsCardCorrect(white, black))
            {
                return "Cards not correct";
            }
            
                var whiteName = "white";
                var blackName = "black";
                var tie = "Tie";

                var whiteHandcard = new HandCards();
                var blackHandcard = new HandCards();

                whiteRank = whiteHandcard.CheckRank(white);
                blackRank = blackHandcard.CheckRank(black);

                if ((int)whiteRank == (int)blackRank)
                {
                    if (whiteHandcard.comparerInSameRank.Count != blackHandcard.comparerInSameRank.Count)
                    {
                        return ("cannot compare in second step");
                    }

                    var length = whiteHandcard.comparerInSameRank.Count;
                    for (int i = 0; i < length; i++)
                    {
                        var whiteComparer = whiteHandcard.ValueOf(whiteHandcard.comparerInSameRank[i]);
                        var blackComparer = blackHandcard.ValueOf(blackHandcard.comparerInSameRank[i]);
                        if (whiteComparer > blackComparer)
                        {
                            white2ndCompare = whiteHandcard.comparerInSameRank[i];
                            black2ndCompare = blackHandcard.comparerInSameRank[i];
                            return whiteName;
                        }
                        if (whiteComparer < blackComparer)
                        {
                            white2ndCompare = whiteHandcard.comparerInSameRank[i];
                            black2ndCompare = blackHandcard.comparerInSameRank[i];
                            return blackName;
                        }
                        if (i == length-1)
                        {
                            return tie;
                        }
                    }
                }
                else
                {
                    if ((int)whiteRank > (int)blackRank)
                    {
                        return whiteName;
                    }
                    else
                    {
                        return blackName;
                    }
                }

                return " comparing has been error";
   
        }

        public bool IsCardCorrect(List<string> white, List<string> black)
        {
            var allCard = new List<string>();
            allCard.AddRange(white);
            allCard.AddRange(black);

            // cond 1
            if( white.Count != 5 || black.Count != 5 )
            {
                return false;
            }
            // cond 2
            string[] value = { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
            string[] suit = { "C", "D", "S", "H" };
            for (int i = 0; i < allCard.Count; i++)
            {
                if ( ! value.Contains( allCard[i].ElementAt(0).ToString() ) )
                {
                    return false;
                }
                if( ! suit.Contains( allCard[i].ElementAt(1).ToString() ))
                {
                    return false;
                }
            }
            // cond 3
               if (allCard.Distinct().Count() < allCard.Count) return false;
            
            // OK
            return true;
        }
    }
}
