using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Convert to char array and reverse
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        Console.WriteLine(reversed);
    }
}
