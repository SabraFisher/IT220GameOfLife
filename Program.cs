// Create a Board class that can have a 2d array of cells, where each cell can be alive or dead. 
// Implement methods to display the board in the console and clear a board state.

namespace IT220GameOfLife
{
    internal class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            Console.WriteLine("Conway's Game of Life");

            // Ask the user for the number of iterations
            Console.Write("Enter the number of iterations to run: ");
            if (!int.TryParse(Console.ReadLine(), out int iterations) || iterations <= 0)
            {
                iterations = 10; // Apply a fallback default if invalid input is provided
                Console.WriteLine($"Invalid input. Defaulting to {iterations} iterations.");
                Thread.Sleep(1500);
            }

            // Create a new board with specified dimensions
            Board board = new Board(40, 10);

            // Populate the board with a random starting state (25% chance of life)
            board.Randomize(0.25);

            // Run the simulation loop
            for (int i = 0; i < iterations; i++)
            {
                board.Display();
                Console.WriteLine($"Iteration: {i + 1} of {iterations}");
                
                // Calculate the next state based on Conway's rules
                board.NextGeneration();

                // Pause slightly so the user can see the progression
                Thread.Sleep(250); 
            }

            Console.WriteLine("\nSimulation completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
