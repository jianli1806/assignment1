using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of integers (space separated):");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> freq = new Dictionary<int, int>();
        int maxFreq = 0;
        int leftmost = arr[0];

        foreach (int num in arr)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
            if (freq[num] > maxFreq)
            {
                maxFreq = freq[num];
                leftmost = num;
            }
            // If tie, keep the first one encountered (leftmost)
        }

        // Check for multiple numbers with the same frequency
        var maxNumbers = freq.Where(kvp => kvp.Value == maxFreq).Select(kvp => kvp.Key).ToList();
        if (maxNumbers.Count > 1)
        {
            // Find the leftmost among them
            foreach (int num in arr)
            {
                if (maxNumbers.Contains(num))
                {
                    leftmost = num;
                    break;
                }
            }
        }

        if (maxNumbers.Count == 1)
        {
            Console.WriteLine($"The number {leftmost} is the most frequent (occurs {maxFreq} times)");
        }
        else
        {
            Console.WriteLine($"The numbers {string.Join(", ", maxNumbers)} have the same maximal frequency (each occurs {maxFreq} times). The leftmost of them is {leftmost}.");
        }
    }
}
