using System;

public class Prompt
    {
    public List<string> _prompts = new List<string>();
    public string RandomPrompt()
        {
            Random random = new Random();
            int list = random.Next(_prompts.Count);
            return _prompts[list];
        }
    }