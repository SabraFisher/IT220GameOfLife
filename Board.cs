using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT220GameOfLife
{
    internal class Board
    {
        // 2D array to represent the cells on the board
        // true represents a live cell and false represents a dead cell
        private bool[,] _cells;
        private int _width;
        private int _height;

        // Properties to access the width and height of the board
        public int Width => _width;
        public int Height => _height;

        // Constructor to initialize the board with specified width and height
        public Board(int width, int height)
        {
            _width = width;
            _height = height;
            _cells = new bool[width, height];
        }
    }
}
