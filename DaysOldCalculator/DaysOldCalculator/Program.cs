using System;

namespace DaysOldCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the birth date
            DateTime birthDate = new DateTime(1995, 5, 7); // Change this to the desired birth date

            // Calculate the current date
            DateTime currentDate = DateTime.Now;

            // Calculate the total days old
            TimeSpan ageSpan = currentDate - birthDate;
            int daysOld = (int)ageSpan.TotalDays;

            Console.WriteLine($"You are {daysOld} days old.");

            // Calculate days to the next 10,000 day anniversary
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

            Console.WriteLine($"Your next 10,000 day anniversary is on: {nextAnniversary.ToShortDateString()}");
        }
    }
}
