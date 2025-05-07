using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter start number: ");
        int startNum = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int endNum = int.Parse(Console.ReadLine());

        int[] primes = FindPrimesInRange(startNum, endNum);

        Console.WriteLine("Prime numbers in the range:");
        foreach (int prime in primes)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = Math.Max(2, startNum); num <= endNum; num++)
        {
            bool isPrime = true;
            int sqrt = (int)Math.Sqrt(num);

            for (int divisor = 2; divisor <= sqrt; divisor++)
            {
                if (num % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(num);
            }
        }

        return primes.ToArray();
    }
}
