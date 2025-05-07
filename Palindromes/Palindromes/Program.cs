using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        // Match words (sequences of letters and numbers)
        var matches = Regex.Matches(input, @"\b\w+\b");

        var palindromes = new HashSet<string>();

        foreach (Match match in matches)
        {
            string word = match.Value;
            if (word.Length > 1 && IsPalindrome(word))
                palindromes.Add(word);
            else if (word.Length == 1) // single letter words are also palindromes
                palindromes.Add(word);
        }

        var sorted = palindromes.ToList();
        sorted.Sort(StringComparer.Ordinal);

        Console.WriteLine(string.Join(", ", sorted));
    }

    static bool IsPalindrome(string s)
    {
        int len = s.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (s[i] != s[len - 1 - i])
                return false;
        }
        return true;
    }
}
