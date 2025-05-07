namespace assign1;
using System;
public class NewTasks
{
    static void Main(string[] args)
    {
        Console.Write("What is your favorite color? ");
        string favoriteColor = Console.ReadLine();

        Console.Write("What is your astrology sign? ");
        string astrologySign = Console.ReadLine();

        Console.Write("What is your street address number? ");
        int streetAddressNumber = Convert.ToInt32(Console.ReadLine());

        string hackerName = favoriteColor + astrologySign + streetAddressNumber;

        Console.WriteLine("Your hacker name is " + hackerName);
    }
}


