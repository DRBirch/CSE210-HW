using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment general = new Assignment("John Smith", "Multiplication");
        Console.WriteLine(general.GetSummary());

        MathHW addition = new MathHW("Jakob Jingelheimerschmidt", "Addition", "12", "1-4");
        Console.WriteLine(addition.GetSummary());
        Console.WriteLine(addition.GetHomework());

        Writing writing = new Writing("Sonofa Gun", "English Lit", "Pronouns and why they stink");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.WritingInformation());
    }
}