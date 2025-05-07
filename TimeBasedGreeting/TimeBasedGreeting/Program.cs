using System;

namespace TimeBasedGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a DateTime variable for testing
            DateTime currentTime = new DateTime(2025, 5, 7, 14, 30, 0); // Example: May 7, 2025, at 2:30 PM
            // Uncomment the line below to use the current time instead
            // DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;

            // Greet the user based on the time of day
            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 17 && hour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            if (hour >= 21 || hour < 5)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
