using System;

public class Activity
{
    protected string _title;
    protected string _description;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_title} Activity.");
        Console.WriteLine(_description);
    }

    public void EndMessage()
    {
        Console.WriteLine($"You finished the {_title} Activity.");
    }
}