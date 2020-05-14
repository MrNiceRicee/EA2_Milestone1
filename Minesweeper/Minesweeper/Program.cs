using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            Board x = new Board(10);
            Console.WriteLine(printBoard(x));
            Console.Read();
        }

        public static String printBoard(Board board)
        {
            String r = "";
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                for (int i = 0; i < board.Grid.GetLength(1); i++)
                {
                         
                    r += "----";
                }
                //do pretty lines on the board
                r += "\n";
                for (int col = 0; col < board.Grid.GetLength(1); col++)
                {
                    var cell = board.Grid[row, col];
                    if (cell.Live)
                    {
                        r += "| o ";
                    }else
                    {
                        r += "| x ";
                    }
                }
                r += "|\n";

                //started a new line
            }
            for (int i = 0; i < board.Grid.GetLength(1); i++)
            {
                r += "----";
            }
            // last separation line on the board
            return r;
        }
    }
}
