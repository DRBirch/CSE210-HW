using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Enos", 6, 7);
        Scripture scripture = new Scripture(reference, 
        "And I, Enos, knew that God could not lie; wherefor, my guilt was swept away; And I said: Lord, how is it done?");

        string input = "";

        while (input != "quit" && scripture.Hidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine();
            Console.WriteLine("Type quit to stop or press enter to continue.");

            input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideWords(3);
            } 
        }
        Console.Clear();
        Console.WriteLine(scripture.DisplayText());
    }
}