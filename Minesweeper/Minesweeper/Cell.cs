﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Cell
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public bool Visited { get; set; }

        public bool Live { get; set; }

        public int LiveNeighbors { get; set; }


        public Cell()
        {
            Row = -1;
            Column = -1;
            Visited = false;
            Live = false;
            LiveNeighbors = 0;
        }
    }
}
