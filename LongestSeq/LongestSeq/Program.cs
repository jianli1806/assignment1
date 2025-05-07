using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of integers (space separated):");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxLen = 1;
        int maxStart = 0;
        int currLen = 1;
        int currStart = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currLen++;
            }
            else
            {
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxStart = currStart;
                }
                currLen = 1;
                currStart = i;
            }
        }

        // Check the last sequence
        if (currLen > maxLen)
        {
            maxLen = currLen;
            maxStart = currStart;
        }

        // Output the longest sequence
        for (int i = 0; i < maxLen; i++)
        {
            Console.Write(arr[maxStart] + " ");
        }
        Console.WriteLine();
    }
}