using System;

class Program
{
    static void Main(string[] args)
    {
        // Input string
        string input = "Hello, World!";

        // Array to store letter counts
        int[] letterCounts = new int[26]; // Assuming only English alphabet letters are counted

        // Convert input string to lowercase to ensure case insensitivity
        input = input.ToLower();

        // Loop through each character in the input string
        foreach (char c in input)
        {
            // Check if the character is a letter
            if (char.IsLetter(c))
            {
                // Calculate the index of the letter in the array (a -> 0, b -> 1, ..., z -> 25)
                int index = c - 'a';

                // Increment the count for the corresponding letter
                letterCounts[index]++;
            }
        }

        // Output the letter counts
        for (int i = 0; i < 26; i++)
        {
            // Convert the index back to the corresponding letter (0 -> a, 1 -> b, ..., 25 -> z)
            char letter = (char)('a' + i);
            Console.WriteLine($"Letter: {letter}, Count: {letterCounts[i]}");
        }
    }
}