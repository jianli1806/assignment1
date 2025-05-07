// See https://aka.ms/new-console-template for more information

using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of centuries: ");
            if (int.TryParse(Console.ReadLine(), out int centuries))
            {
                // Convert centuries to various time units
                long years = centuries * 100L; // Use long to avoid overflow
                long days = years * 365L + (centuries / 4); // Account for leap years
                long hours = days * 24L;
                long minutes = hours * 60L;
                long seconds = minutes * 60L;
                long milliseconds = seconds * 1000L;
                long microseconds = milliseconds * 1000L;
                long nanoseconds = microseconds * 1000L;

                // Output the results
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
