
using System;
using System.Collections.Generic;
using System.IO;

// Define the Journal class
class Journal
{
    // Declare public fields
    public List<Entry> entries;
    PromptGenerator promptGenerator;

    public Journal()
    {
        // Initialize the entries list and the prompt generator
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

// Define the Write method
    public void Write()
    {
        // Get a random prompt from the prompt generator
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: {0}", prompt);

        // Prompt the user to enter their journal entry
        Console.WriteLine("Enter your journal entry:");
        string response = Console.ReadLine();

        // Prompt the user to enter the date and mood for the entry
        Console.WriteLine("Enter the date of this entry (MM/DD/YYYY):");
        string date = Console.ReadLine();

        Console.WriteLine("Enter the mood for this entry:");
        string mood = Console.ReadLine();

        // Create a new Entry object and add it to the entries list
        Entry entry = new Entry(date, prompt, response, mood);
        entries.Add(entry);
        // Print a message confirming that the entry was added to the journal
        Console.WriteLine("Entry added to journal.");
    }

    // Define the Display method
    public void Display()
    {
        // If the entries list is empty, print a message indicating that the journal is empty
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        // Otherwise, print a numbered list of the entries
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

    // Define the Save method
    public void Save()
    {
        // Prompt the user to enter a filename for the journal file
        Console.WriteLine("Enter the file name to save the journal:");
        string fileName = Console.ReadLine();
        // Use a StreamWriter to write the entries to the file in CSV format
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.getEntryAsCSV());
            }
        }
        // Use a StreamWriter to write the entries to the file in CSV format
        Console.WriteLine("Journal saved to file.");
    }

    // Define the Load method
    public void Load()
    {
        // Prompt the user to enter the filename of the journal file to load
        Console.WriteLine("Enter the filename to load:");
        string filename = Console.ReadLine();

        // Check if the file exists; if not, print an error message and return
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File {0} does not exist.", filename);
            return;
        }

        try
        {
             // Use a StreamReader to read the entries from the file and add them to the entries list
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                     // Split the line into parts using the pipe character as a separator
                    string[] parts = line.Split('|');

                    // If the line does not contain 4 parts, print an error message and continue to the next line
                    if (parts.Length != 4)
                    {
                        Console.WriteLine("Error: Line '{0}' does not contain 4 pipe-separated parts and cannot be loaded as an entry.", line);
                        continue;
                    }
                     // Extract the parts 
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    string mood = parts[3];

                    // Create a new Entry object and add it to the entries list
                    Entry entry = new Entry(date, prompt, response, mood);
                    entries.Add(entry);

                    // Display the entry that was just added
                    Console.WriteLine("Entry loaded from file:");
                    // The entry was loaded from file
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