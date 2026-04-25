using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90)
        {
            Console.Write("You got an A in the class!");
        }
        else if (percentage >= 80 && percentage < 90)
        {
            Console.Write("You got a B in the class!");
        }
        else if (percentage >= 70 && percentage < 80)
        {
            Console.Write("You got a C in the class!");
        }
        else if (percentage >= 60 && percentage < 70)
        {
            Console.Write("You got a D in the class!");
        }
        else
        {
            Console.Write("You got an F in the class!");
        }

        if (percentage >= 70)
        {
            Console.Write("Congratulations on passing the class!");
        }
        else
        {
            Console.Write("You did not pass, better luck next time!");
        }
    }
}