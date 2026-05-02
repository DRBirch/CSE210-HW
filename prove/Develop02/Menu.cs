using System;

public class Menu
    {
        public List<Input> _entries = new List<Input>();
        public void AddEntry(Input newEntry)
        {
            _entries.Add(newEntry);
        }
        public void Display()
        {
            foreach (Input entry in _entries)
            {
                entry.DisplayEntry();
            }
        }

        public void SaveFile(string file)
        {
            List<string> lines = new List<string>();
            foreach (Input entry in _entries)
            {
                lines.Add($"{entry._prompt}|{entry._response}|{entry._date}");
            }
            File.WriteAllLines(file, lines);
        }

        public void LoadFile(string file)
        {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();
        foreach (string line in lines)
            {
            string[] pieces = line.Split('|');
            Input item = new Input();
            item._prompt = pieces[0];
            item._response = pieces[1];
            item._date = pieces[2];
            _entries.Add(item);
            }
        }
    }