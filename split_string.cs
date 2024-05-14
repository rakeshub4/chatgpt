using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Input string
        string input = "Hello, World!";

        // Dictionary to store letter counts
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        // Convert input string to lowercase to ensure case insensitivity
        input = input.ToLower();

        // Loop through each character in the input string
        foreach (char c in input)
        {
            // Check if the character is a letter
            if (char.IsLetter(c))
            {
                // Check if the letter already exists in the dictionary
                if (letterCounts.ContainsKey(c))
                {
                    // If the letter exists, increment its count
                    letterCounts[c]++;
                }
                else
                {
                    // If the letter doesn't exist, add it to the dictionary with count 1
                    letterCounts.Add(c, 1);
                }
            }
        }

        // Output the letter counts
        foreach (var kvp in letterCounts)
        {
            Console.WriteLine($"Letter: {kvp.Key}, Count: {kvp.Value}");
        }
    }
}