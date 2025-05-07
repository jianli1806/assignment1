using System;

namespace CountingUpTo24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outer loop for increments (1, 2, 3, 4)
            for (int increment = 1; increment <= 4; increment++)
            {
                // Inner loop for counting up to 24
                for (int count = 0; count <= 24; count += increment)
                {
                    // Print the current count followed by a comma
                    Console.Write(count + (count < 24 ? "," : ""));
                }
                // Move to the next line after each increment
                Console.WriteLine();
            }
        }
    }
}
