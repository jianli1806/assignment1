using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define the separators as a character set for splitting
        string separators = @"[.,:;=\(\)&\[\]""'\\/!? ]";
        // Pattern to match words and separators
        string pattern = @"([A-Za-z0-9\+#]+|[.,:;=\(\)&\[\]""'\\/!? ]+)";

        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // Extract words and separators in order
        var tokens = new List<string>();
        foreach (Match m in Regex.Matches(input, pattern))
            tokens.Add(m.Value);

        // Extract words only (not separators)
        var words = new List<string>();
        foreach (string token in tokens)
        {
            if (!Regex.IsMatch(token, separators))
                words.Add(token);
        }
        words.Reverse();

        // Reconstruct the sentence
        StringBuilder result = new StringBuilder();
        int wordIndex = 0;
        foreach (string token in tokens)
        {
            if (!Regex.IsMatch(token, separators))
                result.Append(words[wordIndex++]);
            else
                result.Append(token);
        }

        Console.WriteLine(result.ToString());
    }
}
