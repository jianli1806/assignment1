using System;

namespace RandomNumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 3
            Random random = new Random();
            int correctNumber = random.Next(1, 4); // 4 is exclusive, so it generates 1, 2, or 3

            Console.WriteLine("Guess a number between 1 and 3:");

            // Read user input
            int guessedNumber = int.Parse(Console.ReadLine());

            // Check the user's guess
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
