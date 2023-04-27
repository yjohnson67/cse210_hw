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

        Console.WriteLine("Enter the mood for this entry:");
        string mood = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response, mood);
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

        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File {0} does not exist.", filename);
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 4)
                    {
                        Console.WriteLine("Error: Line '{0}' does not contain 4 pipe-separated parts and cannot be loaded as an entry.", line);
                        continue;
                    }
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    string mood = parts[3];

                    Entry entry = new Entry(date, prompt, response, mood);
                    entries.Add(entry);

                    // Display the entry that was just added
                    Console.WriteLine("Entry loaded from file:");
                    entry.DisplayEntry();
                }
            }

            Console.WriteLine("Journal loaded from {0}.", filename);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal from {0}: {1}", filename, ex.Message);
        }
    }
}