using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string correct = "False";
        Console.Write("What is the magic number? ");
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);

        while (correct == "False")
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess > number)
                {
                Console.WriteLine("Lower");
                }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                correct = "True";
            }
        }
    }
}