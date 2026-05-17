using System;
using System.Collections.Generic;
using System.Threading;

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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long should the activity run? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to start.");
        Spinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGood job!");
        Spinner(3);
        Console.WriteLine($"You finished the {_title} Activity.");
        Spinner(3);
    }

    public void Spinner(int seconds)
    {
        List<string> spinner = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\"
        };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
            if(i >= spinner.Count)
            {
                i=0;
            }
        }
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