using System;

public class Listing : Activity
{
    public Listing() : base(
            "Listing",
            "This activity helps you list positive things.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("List people you appreciate.");

        EndMessage();
    }
}