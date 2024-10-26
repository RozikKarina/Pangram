using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string sentence)
    {
        // Check if the sentence contains all 26 letters of the alphabet
        return sentence
            .ToLower()                           // Convert to lowercase to handle case-insensitivity
            .Where(char.IsLetter)                // Filter only letters
            .Distinct()                          // Remove duplicates
            .Count() == 26;                      // Check if we have all 26 letters
    }
}