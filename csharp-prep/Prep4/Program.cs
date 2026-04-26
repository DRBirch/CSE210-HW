using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 1;
        int sum = 0;

        while (input != 0)
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            input = int.Parse(inputNumber);
            numbers.Add(input);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
            sum = sum + numbers[i];
        }
        int average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}