using System;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();

        string userName = askName();
        int userNumber = askNumber();
        int squaredNumber = SquareNumber(userNumber);
        int birthYear;
        askBirthYear(out birthYear);
        Result(userName, squaredNumber, birthYear);
    }

    static void displayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string askName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int askNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
    static void askBirthYear(out int birthYear)
    {
        Console.Write($"Enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}