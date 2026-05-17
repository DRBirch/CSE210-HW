using System;

public class Breathing : Activity
{
    public Breathing() : base(
            "Breathing",
            "This activity helps you relax through breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Breathe out...");

        EndMessage();
    }
}