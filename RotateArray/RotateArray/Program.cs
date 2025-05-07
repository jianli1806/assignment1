using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Read and parse the array
        string[] input = Console.ReadLine().Split();
        int n = input.Length;
        int[] arr = input.Select(int.Parse).ToArray();

        // Read the number of rotations
        int k = int.Parse(Console.ReadLine());

        // Array to store the sum
        int[] sum = new int[n];

        // Perform rotations and sum
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotated[(i + r) % n] = arr[i];
            }

            // Add to sum
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
        }

        // Output the result
        Console.WriteLine(string.Join(" ", sum));
    }
}
