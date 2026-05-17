using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    private List<string> _prompt = new List<string>()
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };

    private List<string> _reflection = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this ecperience in mind in the future?",
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

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            int questionNumber = random.Next(_reflection.Count);
            string question = _reflection[questionNumber];
            Console.WriteLine(question);
            Spinner(5);
        }

        EndMessage();
    }
}