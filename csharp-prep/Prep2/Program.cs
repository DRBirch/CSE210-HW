using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "A";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your overall grade is {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("You did not pass, better luck next time!");
        }
    }
}