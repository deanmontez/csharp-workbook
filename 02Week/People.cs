using System;

public class Program
{
    public static void Main()
    {
        //Instantiate a new object
        var human = new Person();

        human.Height = 100;
        human.Name = "Deandre";
        human.LastName = "Crayton";

        human.Greeting();

        Console.ReadLine();
    }
}

public class Person
{
    //Properties
    public decimal Height { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

    //Methods
    public void Greeting()
    {
        Console.WriteLine("Hello my name is " + Name + " " + LastName);
    }
}