using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompts = new Prompt();
        Menu myJournal = new Menu();
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("What made me smile today?");
        prompts._prompts.Add("How did I see the hand of the Lorde in my life today?");
        prompts._prompts.Add("How did I help someone else today?");
        prompts._prompts.Add("If I could redo anything today what would it be?");
        prompts._prompts.Add("If there was one thing I would never change about today what would it be?");
        
        int menu = 0;
        while (menu !=5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
        
            string menuInput = Console.ReadLine();
            menu = int.Parse(menuInput);
            if (menu == 1)
            {
                string randomPrompt = prompts.RandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();

                Input newEntry = new Input();
                Console.WriteLine("Enter today's date: ");
                string date = Console.ReadLine();

                Console.WriteLine("What was the overall mood for today? ");
                string emotion = Console.ReadLine();

                Console.WriteLine("Who is the person of the day today? ");
                string personOfDay = Console.ReadLine();

                newEntry._date = date;
                newEntry._prompt = randomPrompt;
                newEntry._response = response;
                newEntry._mood = emotion;
                newEntry._person = personOfDay;

                myJournal.AddEntry(newEntry);
            }
            else if (menu == 2)
            {
                myJournal.Display();
            }
            else if (menu == 3)
            {
                Console.Write("Enter file name: ");
                string file = Console.ReadLine();
                myJournal.SaveFile(file);
            }
            else if (menu == 4)
            {
                Console.Write("Enter file name: ");
                string file = Console.ReadLine();
                myJournal.LoadFile(file);
            }
        }
    }
}