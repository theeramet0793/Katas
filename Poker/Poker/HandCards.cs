using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Poker.Enum;

namespace Poker
{
    public class HandCards
    {
        // ---------------------------------------------------------------------- //
        /*
         * 5 4 3 2 A ไม่ได้เพราะโจทย์นี้ไม่เหมือน poker จริง
         * straight flush   = ค่าเรียงกัน 5 ใบ + suit เหมือนกัน เรียงตามค่ามากสุด
         * four of a  kind  = ค่าเหมือนกัน 4 ใบ เรียงตามค่าของ 4 ใบนั้น
         * full house       = ค่าเหมือนกัน 3 ใบ + 1 pair เรียงตามค่าของ 3 ใบ
         * flush            = suit เหมือนกัน 5 ใบ เรียงตามค่าของใบที่มากทีสุด
         * straight         = ค่าเรียงกัน 5 ใบ เรียงตามใบที่ค่ามากที่สุด
         * three of a kind  = ค่าเหมือนกัน 3 ใบ เรียงตามค่าของ 3 ใบนั้น
         * two pairs        = มี 2 pairs ที่เเตกต่างกัน เรียงตามคู่ที่ค่าสูงที่สุด ถ้าเท่ากัน เรียงตามค่าของอีกคู่ ถ้าเท่ากัน เรียงตามค่าของใบเดี่ยว
         * pair             = ค่าเหมือนกัน 2 ใบ เรียงตามค่าของคู่นั้น ถ้าเท่ากัน เรียงตามค่าสูงสุดของใบที่เหลือ
         * high card        = เรียงตามค่าที่มากสุดของใบเดี่ยว
         * */
        // ---------------------------------------------------------------------- //

        public PokerRank pokerRank { get; private set; } = PokerRank.None;
        public List<string> comparerInSameRank { get; private set; } = new List<string>();

        // ---------------------- main method --------------------------- //
        public PokerRank CheckRank(List<string> fiveCards)
        {
            pokerRank = PokerRank.None;
            if ( IsStraightFlush(fiveCards))
            {
                pokerRank = PokerRank.StraightFlush;
            }
            else if(IsFourOfAKind(fiveCards))
            {
                pokerRank = PokerRank.FourOfAKind;
            }
            else if (IsFullhouse(fiveCards))
            {
                pokerRank = PokerRank.Fullhouse;
            }
            else if (IsFlush(fiveCards))
            {
                pokerRank = PokerRank.Flush;
            }
            else if (IsStraight(fiveCards))
            {
                pokerRank = PokerRank.Straight;
            }
            else if (IsThreeOfAKind(fiveCards))
            {
                pokerRank = PokerRank.ThreeOfAKind;
            }
            else if (IsTwoPairs(fiveCards))
            {
                pokerRank = PokerRank.TwoPair;
            }
            else if (IsPairs(fiveCards))
            {
                pokerRank = PokerRank.Pair;
            }
            else if (IsHighcard(fiveCards))
            {
                pokerRank = PokerRank.Highcard;
            }
            return pokerRank;
        }
        // ---------------------- helping method --------------------------- //
        public List<string> SortByValue(List<string> fiveCard)
        { // insertion sorting algorithm
            for (int i = 1; i < fiveCard.Count; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ValueOf(fiveCard[i]) >= ValueOf(fiveCard[j]))
                    {
                        var temp = fiveCard[i];
                        fiveCard.RemoveAt(i);
                        fiveCard.Insert(j + 1, temp);
                        break;
                    }
                    else if (j == 0)
                    {
                        var temp = fiveCard[i];
                        fiveCard.RemoveAt(i);
                        fiveCard.Insert(j, temp);
                        break;
                    }
                }
            }

            return fiveCard;
        }

        public int ValueOf(string OneCard)
        {
            string value = OneCard.ElementAt(0).ToString();
            switch (value)
            {
                case "2": return 1;
                case "3": return 2;
                case "4": return 3;
                case "5": return 4;
                case "6": return 5;
                case "7": return 6;
                case "8": return 7;
                case "9": return 8;
                case "T": return 9;
                case "J": return 10;
                case "Q": return 11;
                case "K": return 12;
                case "A": return 13;
                default: throw new Exception("Invalid argument of ValueOf()");
            }
        }

        public bool IsConsecutiveValue(List<string> fiveCard)
        {
            var sortedfiveCard = SortByValue(fiveCard);
            for (int i = 1; i < sortedfiveCard.Count; i++)
            {
                if (ValueOf(sortedfiveCard[i]) != ValueOf(sortedfiveCard[i - 1]) + 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSameSuit(List<string> Cards)
        {
            var comparerCard = Cards[0].ElementAt(1).ToString();
            for (int i = 1; i < Cards.Count; i++)
            {
                if (Cards[i].ElementAt(1).ToString() != comparerCard)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSameValue(List<string> Cards)
        {
            var comparerCard = Cards[0].ElementAt(0).ToString();
            for (int i = 1; i < Cards.Count; i++)
            {
                if (Cards[i].ElementAt(0).ToString() != comparerCard)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsDistinctValue(List<string> Cards)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                for (int j = i+1; j < Cards.Count; j++)
                {
                    if( Cards[i].ElementAt(0) == Cards[j].ElementAt(0) )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<string> CreateSubCardByIndex( List<string> mainCards, List<int> selectedIndex)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < selectedIndex.Count; i++)
            {
                result.Add(mainCards[selectedIndex[i]]);
            }
            return result;
        }

        public List<string> CreateSubCardsByRange(List<string> cards, int startIndex, int lastIndex)
        {
            if (startIndex < 0 || lastIndex < 0) throw new ArgumentOutOfRangeException();
            if (lastIndex < startIndex) throw new Exception();

            List<string> result = new List<string>();
            for( int i = 0; i < cards.Count; i++)
            {
                if( i >= startIndex && i <= lastIndex)
                {
                    result.Add(cards[i]);
                }
            }
            return result;
            
        }

        // --------------------- Hand ranking method -------------------------------- //
        public bool IsStraightFlush(List<string> fiveCard)
        {
            if (IsConsecutiveValue(fiveCard) && IsSameSuit(fiveCard))
            { 
                var sortedCards = SortByValue(fiveCard);
                comparerInSameRank.Add( sortedCards.Last() );
                return true; 
            }
            else
                return false;
        }

        public bool IsFourOfAKind(List<string> fiveCard)
        {
            fiveCard = SortByValue(fiveCard);
            var last4card = CreateSubCardsByRange(fiveCard, 1, 4);
            var first4card = CreateSubCardsByRange(fiveCard, 0, 3);
            var mustDistinctcard = CreateSubCardByIndex(fiveCard, new List<int> { 0, fiveCard.Count-1 });

            if (IsSameValue(last4card) && IsDistinctValue(mustDistinctcard) )
            {
                comparerInSameRank.Add((last4card[0]));
                return true;
            }
            else if (IsSameValue(first4card) && IsDistinctValue(mustDistinctcard) )
            {
                comparerInSameRank.Add((first4card[0]));
                return true;
            }

            return false;
        }

        public bool IsFullhouse (List<string> fiveCards)
        {
            fiveCards = SortByValue(fiveCards);

            var first3card = CreateSubCardsByRange(fiveCards, 0, 2);
            var first2card = CreateSubCardsByRange(fiveCards, 0, 1);
            var last2card = CreateSubCardsByRange(fiveCards, 3, 4);
            var last3card = CreateSubCardsByRange(fiveCards, 2, 4);
            var HeadAndTailCard =CreateSubCardByIndex(fiveCards, new List<int> { 0, fiveCards.Count-1 });

            if( !IsSameValue( HeadAndTailCard) )
            if(IsSameValue(first3card))
            {
                if (IsSameValue(last2card)) 
                    {
                        comparerInSameRank.Add((first3card[0]));
                        return true; 
                    }
            }
            else if(IsSameValue(last3card))
            {
                if(IsSameValue(first2card))
                    {
                        comparerInSameRank.Add((last3card[0]));
                        return true;
                    }
                }

            return false;
        }

        public bool IsFlush (List<string> fiveCards)
        {
            if (IsSameSuit(fiveCards))
            {
                var highestCard = SortByValue(fiveCards).Last();
                comparerInSameRank.Add((highestCard) );
                return true;
            }
            return false;
        }

        public bool IsStraight(List<string> fiveCards)
        {
            if ( IsConsecutiveValue(fiveCards))
            {
                var highestCard = SortByValue(fiveCards).Last();
                comparerInSameRank.Add((highestCard));
                return true;
            }

            return false;
        }

        public bool IsThreeOfAKind(List<string> fiveCards)
        {
            fiveCards = SortByValue(fiveCards);

            var first3card = CreateSubCardsByRange(fiveCards, 0, 2);
            var first2card = CreateSubCardsByRange(fiveCards, 0, 1);
            var last2card = CreateSubCardsByRange(fiveCards, 3, 4);
            var last3card = CreateSubCardsByRange(fiveCards, 2, 4);

            if (IsSameValue(first3card))
            {
                if (!IsSameValue(last2card))
                {
                    comparerInSameRank.Add((first3card[0]));
                    return true;
                }
            }
            else if (IsSameValue(last3card))
            {
                if (!IsSameValue(first2card))
                {
                    comparerInSameRank.Add((last3card[0]));
                    return true;
                }
            }

            return false;
        }

        public bool IsTwoPairs(List<string> fiveCards)
        {
            fiveCards = SortByValue(fiveCards);

            // pair set 1
            var cardPair1_2 = CreateSubCardsByRange(fiveCards, 0, 1);
            var cardPair3_4 = CreateSubCardsByRange(fiveCards, 2, 3);
            
            // pair set 2
            var cardPair2_3 = CreateSubCardsByRange(fiveCards, 1, 2);
            var cardPair4_5 = CreateSubCardsByRange(fiveCards, 3, 4);

            var cardsMustDistinct = CreateSubCardByIndex(fiveCards, new List<int> { 0,2,4 });

            if( IsDistinctValue(cardsMustDistinct) )
            {
                if( IsSameValue(cardPair1_2) && IsSameValue( cardPair3_4) )
                {
                    if( ValueOf(cardPair1_2[0]) > ValueOf(cardPair3_4[0]))
                    {
                        comparerInSameRank.Add( (cardPair1_2[0]) );
                        comparerInSameRank.Add( (cardPair3_4[0]) );
                        comparerInSameRank.Add( (fiveCards.Last()) );
                    }
                    else
                    {
                        comparerInSameRank.Add((cardPair3_4[0]));
                        comparerInSameRank.Add((cardPair1_2[0]));
                        comparerInSameRank.Add((fiveCards.Last()));
                    }
                    return true;
                }
                if( IsSameValue(cardPair2_3) && IsSameValue( cardPair4_5) )
                {
                    if (ValueOf(cardPair2_3[0]) > ValueOf(cardPair4_5[0]))
                    {
                        comparerInSameRank.Add((cardPair2_3[0]));
                        comparerInSameRank.Add((cardPair4_5[0]));
                        comparerInSameRank.Add((fiveCards.First()));
                    }
                    else
                    {
                        comparerInSameRank.Add((cardPair4_5[0]));
                        comparerInSameRank.Add((cardPair2_3[0]));
                        comparerInSameRank.Add((fiveCards.First()));
                    }
                    return true;
                }
            }

            return false;
        }

        public bool IsPairs(List<string> fiveCards)
        {
            fiveCards = SortByValue(fiveCards);

            // pair set 1
            var cardPair1_2 = CreateSubCardsByRange(fiveCards, 0, 1);
            // pair set 2
            var cardPair2_3 = CreateSubCardsByRange(fiveCards, 1, 2);
            // pair set 3
            var cardPair3_4 = CreateSubCardsByRange(fiveCards, 2, 3);
            // pair set 4
            var cardPair4_5 = CreateSubCardsByRange(fiveCards, 3, 4);

            if (IsSameValue(cardPair1_2))
            {
                var cardsMustDistinct = CreateSubCardByIndex(fiveCards, new List<int> { 2, 3, 4 });
                if (IsDistinctValue(cardsMustDistinct))
                {
                    return true;
                }
            }
            else if (IsSameValue(cardPair2_3))
            {
                var cardsMustDistinct = CreateSubCardByIndex(fiveCards, new List<int> { 0, 3, 4 });
                if (IsDistinctValue(cardsMustDistinct))
                {
                    return true;
                }
            }
            else if (IsSameValue(cardPair3_4))
            {
                var cardsMustDistinct = CreateSubCardByIndex(fiveCards, new List<int> { 0, 1, 4 });
                if (IsDistinctValue(cardsMustDistinct))
                {
                    return true;
                }
            }
            else if (IsSameValue(cardPair4_5))
            {
                var cardsMustDistinct = CreateSubCardByIndex(fiveCards, new List<int> { 0, 1, 2 });
                if (IsDistinctValue(cardsMustDistinct))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHighcard(List<string> fiveCards)
        {
            if( IsDistinctValue(fiveCards))
            {
                var sortedCards = SortByValue(fiveCards);
                comparerInSameRank.Add(( sortedCards.Last() ));
                return true;
            }
            return false;
        }
    }
}
