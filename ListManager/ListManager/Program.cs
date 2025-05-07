using System;
using System.Collections.Generic;

namespace ListManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            string command;

            while (true)
            {
                Console.WriteLine("\nCurrent List:");
                if (items.Count == 0)
                {
                    Console.WriteLine("The list is empty.");
                }
                else
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine("- " + item);
                    }
                }

                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                command = Console.ReadLine();

                if (command.Trim() == "--")
                {
                    items.Clear();
                    Console.WriteLine("List cleared.");
                }
                else if (command.StartsWith("+"))
                {
                    string itemToAdd = command.Substring(1).Trim();
                    if (!string.IsNullOrEmpty(itemToAdd))
                    {
                        items.Add(itemToAdd);
                        Console.WriteLine($"Added: {itemToAdd}");
                    }
                    else
                    {
                        Console.WriteLine("No item to add.");
                    }
                }
                else if (command.StartsWith("-"))
                {
                    string itemToRemove = command.Substring(1).Trim();
                    if (items.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {itemToRemove}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
            }
        }
    }
}
