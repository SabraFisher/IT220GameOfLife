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

        // Indexer to access individual cells
        public bool this[int x, int y]
        {
            get => _cells[x, y];
            set => _cells[x, y] = value;
        }

        // Get the length of a dimension (0 for width, 1 for height)
        public int GetLength(int dimension)
        {
            return _cells.GetLength(dimension);
        }

        // Display the board in the console
        public void Display()
        {
            Console.Clear();

            // Each cell takes 3 characters wide (│ █ │) and 2 lines tall
            for (int y = 0; y < _height; y++)
            {
                // Draw top border of cells
                for (int x = 0; x < _width; x++)
                {
                    Console.Write(x == 0 ? "┌─" : "┬─");
                }
                Console.WriteLine("┐");

                // Draw cell content
                for (int x = 0; x < _width; x++)
                {
                    Console.Write("│");
                    Console.Write(_cells[x, y] ? "█" : " ");
                }
                Console.WriteLine("│");
            }

            // Draw bottom border
            for (int x = 0; x < _width; x++)
            {
                Console.Write(x == 0 ? "└─" : "┴─");
            }
            Console.WriteLine("┘");

            Console.ResetColor();
        }

        // Clear the board (set all cells to dead)
        public void Clear()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _cells[x, y] = false;
                }
            }
        }
    }
}