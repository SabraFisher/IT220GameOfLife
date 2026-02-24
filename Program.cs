// Create a Board class that can have a 2d array of cells, where each cell can be alive or dead. 
// Implement methods to display the board in the console and clear a board state.

namespace IT220GameOfLife
{
    internal class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Display a welcome message and wait for the user to start the game
            Console.WriteLine("Conway's Game of Life");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            // Create a new board with specified dimensions
            Board board = new Board(40, 10);

            // Display the board
            board.Display();

            // Example: Clear the board if needed
            // board.Clear();
        }
    }
}
