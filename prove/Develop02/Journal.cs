using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    List<string> entries;
    public Journal()
    {
        entries = List<string>();
    }

     public void Write()
    {
        Console.WriteLine("Enter your journal entry:");
        string entry = Console.ReadLine();
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
                Console.WriteLine("{0}. {1}", i + 1, entries[i]);
            }
        }
    }
   
    public void Save()
    {
        Console.WriteLine("Enter the file name to save the journal:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal saved to file.");
    }
    public void Load()
    {
           Console.WriteLine("Enter the file name to load the journal:");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    entries.Add(line);
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}