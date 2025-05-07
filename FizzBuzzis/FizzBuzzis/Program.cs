// See https://aka.ms/new-console-template for more information

using System;

namespace FizzBuzzis
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz Game
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Random Number Guessing Game
            int correctNumber = new Random().Next(3) + 1; // Generates a number between 1 and 3
            Console.WriteLine("Guess a number between 1 and 3:");

            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
        }
    }
}
