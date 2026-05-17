using System;

public class Listing : Activity
{
    private List<string> _prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing() : base(
            "Listing",
            "This activity helps you list positive things.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("List things until the time runs out.");
        int number = random.Next(_prompt.Count);
        string prompt = _prompt[number];
        Console.WriteLine(prompt);
        Console.WriteLine("\nStart listing:");
        Countdown(4);

        EndMessage();
    }
}