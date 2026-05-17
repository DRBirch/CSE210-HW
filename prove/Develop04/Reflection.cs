using System;

public class Reflection : Activity
{
    private List<string> _prompt = new List<string>()
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    public Reflection() : base(
            "Reflection",
            "This activity helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("\nConsider this question");
        int number = random.Next(_prompt.Count);
        string prompt = _prompt[number];
        Console.WriteLine(prompt);
        Console.WriteLine("\nReflect on this");
        Countdown(4);

        EndMessage();
    }
}