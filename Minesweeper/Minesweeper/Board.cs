using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Board
    {
        public int Size { get; set; }

        public Cell[,] Grid { get; set; }

        public double Difficulty { get; set; }

        Random random = new Random();

        public Board(int size)
        {
            Size = size;
            Grid = new Cell[size, size];
            Difficulty = .5;
            setupLiveNeighbors(Grid);
        }


        public void setupLiveNeighbors(Cell[,] cells)
        {
            int LiveNumbers = 0;
            int count = 0;
            for (int col = 0; col < cells.GetLength(0); col++)
            {
                for (int row = 0; row < cells.GetLength(1); row++)
                {
                    cells[col, row] = new Cell();
                    count++;
                    if (LiveNumbers < ((Size*Size)*Difficulty)) {
                        //hard limit the amount of cells to be live to the difficulty
                        if (random.Next(0, (Size*Size)) > ((Size*Size)*Difficulty))
                        {
                            //get total max and multiplied by difficulty, to find the point to calculate the percentage
                            cells[col, row].Live = true;
                            LiveNumbers++;
                            Console.WriteLine("Position:"+count+". Live:"+LiveNumbers+".\t"+col +","+row);
                        }
                    }
                }
                
            }
        }

    }
}
