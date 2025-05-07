using System;

namespace CopyingArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create an initial array with 10 items
            int[] originalArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Step 2: Create a second array with the same length as the original
            int[] copiedArray = new int[originalArray.Length];

            // Step 3: Use a loop to copy values from the original array to the new array
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            // Step 4: Print the contents of both arrays
            Console.WriteLine("Original Array:");
            foreach (int item in originalArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Copied Array:");
            foreach (int item in copiedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
