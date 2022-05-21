using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNamespace
{
    public class TicTacToe
    {
        public string[,] table = new string[3,3];
        private int rowCount = 3;
        private int columnCount = 3;
        private int[] columnHeaderIndex = { 0, 1, 2 };
        private int[] rowHeaderIndex = { 0, 3, 6 };
   

        public void showTable()
        {
            Console.WriteLine($"\n        +---+---+---+");
            for(int i = 0; i<rowCount; i++)
            {
                Console.Write($"        |");
                for (int j =0; j<columnCount; j++)
                {
                    Console.Write($" {table[i, j]} |");
                }
                Console.WriteLine($"\n        +---+---+---+");
            }
        }

        public void InitiateCellNumber()
        {
            int number = 1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    table[i, j] = number.ToString();
                    number++;
                }
            }
        }

        public bool TakenAtCell(int cellNumber, string takenSymbol)
        {
            int count = cellNumber;
            int column = (int) ( cellNumber % columnCount )-1;
            if ( column < 0 ) column = columnCount-1;
            int row = (int) ( Math.Ceiling( (double) cellNumber / rowCount) -1 );
            
            if ( cellNumber < 1 || cellNumber > 9) 
                return false;
            else if ( table [ row, column] == "X" || table [ row, column ] == "O") 
                return false;
            else
            {
                table[row, column] = takenSymbol;
                return true;
            }
            
        }

        public string? CheckWinner()
        {
            var vert = CheckVerticalBingo();
            var hori = CheckHorizontalBingo();
            var Diag1 = CheckDiagonal_1_Bingo();
            var Diag2 = CheckDiagonal_1_Bingo();

            if ( vert != null) return vert;
            else if (hori != null) return hori;
            else if (Diag1 != null) return Diag1;
            else if (Diag2 != null) return Diag2;
            else return null;
        }

        public string? CheckVerticalBingo()
        {
            for (int i = 0; i < columnCount; i++)
            {
                string comparator = table[0, i];
                for(int j = 1; j < rowCount; j++)
                {
                    if (table[j, i] == comparator)
                    {
                        if (j == columnCount - 1)
                            return comparator;
                    }
                    else   
                        break;
                }                
            }
            return null;
        }

        public string? CheckHorizontalBingo()
        {
            for (int i = 0; i < columnCount; i++)
            {
                string comparator = table[i, 0];
                for (int j = 1; j < columnCount; j++)
                {
                    if (table[i, j] == comparator)
                    {
                        if (j == columnCount - 1)
                            return comparator;
                    }
                    else
                        break;
                }
            }
            return null;
        }

        public string? CheckDiagonal_1_Bingo()
        {
            // Up-left  -> down-right
            string comparator = table[0, 0];
            for (int i = 0; i < rowCount; i++)
            {
                if (table[i, i] != comparator)
                    return null;
            }
            return comparator;
            
        }

        public string? CheckDiagonal_2_Bingo()
        {
            // Up-right  -> down-left
            int col = columnCount - 1;
            string comparator = table[0, col];
            for (int i = 0; i < rowCount; i++)
            {
                if (table[i, col] != comparator)
                    return null;
                col--;
            }
            return comparator;

        }

        public bool IsFullTable()
        {
            for(int i=0; i < rowCount; i++)
            {
                for(int j=0; j < columnCount; j++)
                {
                    if(table[i, j] != "X" && table[i,j] != "O") return false;
                }
            }
            return true;
        }


    }
}
