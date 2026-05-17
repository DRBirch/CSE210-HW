using System;

public class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_title} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long should the activity run? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndMessage()
    {
        Console.WriteLine($"You finished the {_title} Activity.");
    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}