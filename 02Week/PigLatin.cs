using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine();
        Console.WriteLine(translateWord(word));
        Console.ReadLine();
    }
    
    public static string translateWord(string word)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
        int vowelPosition = word.IndexOfAny(vowels);

        if (vowelPosition != -1)
        {
            string firstCharacters = word.Substring(0, vowelPosition);
            string endOfWord = word.Substring(vowelPosition);
            word = endOfWord + firstCharacters + "ay";
            return word.ToLower();
        }
        else
        {
            return word;
        }
    }
}
