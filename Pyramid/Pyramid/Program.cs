using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5; // You can change this to make the pyramid taller

            // Outer loop for each line
            for (int i = 1; i <= height; i++)
            {
                // Inner loop for spaces
                for (int j = i; j < height; j++)
                {
                    Console.Write(" "); // Print space
                }

                // Inner loop for stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Print star
                }

                // Move to the next line after printing stars
                Console.WriteLine();
            }
        }
    }
}
