using System;
using System.Collections.Generic;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base(
            "Breathing",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.Write("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(6);
        }  
        EndMessage();
    }
}