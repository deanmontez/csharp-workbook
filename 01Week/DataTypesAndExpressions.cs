using System;

public class Program
{
	public static void Main()
	{
        //Program #1:
        //Write a C# program that takes two numbers as input
        //adds them together, and displays the result of that operation

        //Ask for first number
        Console.WriteLine("What's the first number?");

        //Validate and save number
        int firstNumber;

        var userInput = int.TryParse(Console.ReadLine(), out firstNumber);

        if(!userInput)
        {
            firstNumber = 0;
        }

        //Ask for second number
        Console.WriteLine("What's the second number?");

        //Save second number (same way as above)
        int secondNumber;

        userInput = int.TryParse(Console.ReadLine(), out secondNumber);

        if (!userInput)
        {
            firstNumber = 0;
        }

        //Add Numbers
        int sum = firstNumber + secondNumber;

        //Show Results
        Console.WriteLine("The result is: " + sum);

        //Program #2:
        //Write a C# program that coverts yards to inches

        //Prompt user for yards
        Console.WriteLine("Yards: ");

        //Store input to 'yards' variable
        var yards = int.Parse(Console.ReadLine());

        //Convert yards to inches and store to 'inches' variable
        var inches = yards * 36;

        //Show Results
        Console.WriteLine("Inches: " + inches);
        Console.ReadLine();

        //Programs #3 - 7:
        var people = true;
        var f = false;
        var num = 3.3m;
        Console.WriteLine(num * num);
        var firstName = "Deandre";
        var lastName = "Crayton";
        var age = 20;
        var jov = "Server";
        var favoriteBand = "Radiohead";
        var favoriteSportsTeam = "";
        Console.WriteLine("Kid A is considered " + favoriteBand + "'s best album");
        Console.ReadLine();
    }
}
