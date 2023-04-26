using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> entries;
    PromptGenerator promptGenerator;
    
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void Write()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: {0}", prompt);

        Console.WriteLine("Enter your journal entry:");
        string response = Console.ReadLine();

        Console.WriteLine("Enter the date of this entry (MM/DD/YYYY):");
        string date = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
        Console.WriteLine("Entry added to journal.");
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("Journal entries:");
            for (int i = 0; i < entries.Count; i++)
            {
                Console.WriteLine("{0}.", i + 1);
                entries[i].DisplayEntry();
            }
        }
    }

    public void Save()
    {
        Console.WriteLine("Enter the file name to save the journal:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.getEntryAsCSV());
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void Load()
     {
        Console.WriteLine("Enter the filename to load:");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded from {0}.", filename);
    }
}