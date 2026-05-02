using System;

public class Input
    {
        public string _prompt;
        public string _response;
        public string _date;
        public string _mood;
        public string _person;

        public void DisplayEntry()
            {
                Console.WriteLine($"Prompt: {_prompt}");
                Console.WriteLine($"Response: {_response}");
                Console.WriteLine($"Date: {_date}");
                Console.WriteLine($"Mood of the day: {_mood}");
                Console.WriteLine($"Favorite person of the day: {_person}");
            }
    }