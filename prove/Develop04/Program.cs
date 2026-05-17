using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        Console.Write("\nChoose an activity: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Breathing activity = new Breathing();
            activity.Run();
        }
        else if (choice == "2")
        {
            Reflection activity = new Reflection();
            activity.Run();
        }
        else if (choice == "3")
        {
            Listing activity = new Listing();
            activity.Run();
        }
    }
}