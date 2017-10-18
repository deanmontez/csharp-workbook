using System;

public class Program
{
    // possible letters in code
    public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    
    // size of code
    public static int codeSize = 4;
    
    // number of allowed attempts to crack the code
    public static int allowedAttempts = 3;
    
    // number of tried guesses
    public static int numTry = 0;
    
    // test solution
    public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
    
    // game board
    public static string[][] board = new string[allowedAttempts][];

    // user guess
    public static char[] guess = new char[4];


    public static void Main()
    {
        CreateBoard();
        DrawBoard();
        PromptUser();

        while (!CheckSolution(guess) && numTry < allowedAttempts)
        {
            PromptUser();

            if (numTry == allowedAttempts)
                Console.WriteLine("You ran out of turns! The solution was " + string.Join("", solution));
        }

        Console.ReadLine();
        return;
    }

    public static void PromptUser()
    {
        Console.WriteLine("Enter Guess:");
        guess = Console.ReadLine().ToCharArray();
        InsertCode(guess);
        DrawBoard();

        if (CheckSolution(guess))
            Console.WriteLine("You Won!");

        return;
    }

    public static bool CheckSolution(char[] guess)
    {
        if (string.Join("", guess) == string.Join("", solution))
        {
            return true;
        }
        return false;
    }
    
    public static string GenerateHint(char[] solution, char[] guess)
    {
        char[] solutionClone = (char[]) solution.Clone();
        int correctLetterLocations = 0;
        int correctLetters = 0;

        for (var i = 0; i < codeSize; i++)
        {
            int targetIndex = Array.IndexOf(solutionClone, guess[i]);

            //Check if any character in the guess is an exact match (position wise) in the solution
            if (guess[i] == solutionClone[i])
            {
                solutionClone[i] = ' ';
                correctLetterLocations++;
            }
            //Check if any character in the guess exists in the solution
            if (targetIndex != -1)
            {
                solutionClone[targetIndex] = ' ';
                correctLetters++;
            }
        }

        return correctLetterLocations.ToString() + " - " + correctLetters.ToString();
    }
    
    public static void InsertCode(char[] guess)
    {
        for (var i = 0; i < codeSize; i++)
        {
            board[numTry][i] = guess[i].ToString();
        }

        numTry++;

        return;
    }
    
    public static void CreateBoard()
    {
        for (var i = 0; i < allowedAttempts; i++)
        {
            board[i] = new string[codeSize + 1];
            for (var j = 0; j < codeSize + 1; j++)
            {
                board[i][j] = " ";
            }
        }
        return;
    }
    
    public static void DrawBoard()
    {
        Console.WriteLine("\n");
        for (var i = 0; i < board.Length; i++)
        {
            Console.WriteLine("|" + String.Join("|", board[i]));
        }
        Console.WriteLine("\n");

        return;
    }
    
    public static void GenerateRandomCode() {
        Random rnd = new Random();
        for(var i = 0; i < codeSize; i++)
        {
            solution[i] = letters[rnd.Next(0, letters.Length)];
        }
        return;
    }
}
