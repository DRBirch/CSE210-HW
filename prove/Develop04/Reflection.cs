using System;

public class Reflection : Activity
{
    public Reflection() : base(
            "Reflection",
            "This activity helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("Think of a time you helped someone.");
        Console.WriteLine("Why was this meaningful to you?");

        EndMessage();
    }
}