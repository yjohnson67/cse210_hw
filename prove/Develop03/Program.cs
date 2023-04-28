using System;
using System.Collections.Generic;

class Program
{
    // Define the main method
    static void Main(string[] args)
    {

        // Create a list of scripture objects
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
        scriptures.Add(new Scripture("Psalm", 23, 1, "The Lord is my shepherd, I lack nothing."));

        // Create a new instance of the random class
        Random rand = new Random();

        // Create an infinite loop that presents random scriptures to the user
        while (true)
        {
            Console.Clear();
            // Select a random scripture from the list
            Scripture randomScripture = scriptures[rand.Next(0, scriptures.Count)];

            // Display the scripture reference and text
            Console.WriteLine(randomScripture.GetReference());
            Console.WriteLine(randomScripture.GetText());
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Split the text of the scripture into an array of words
            string[] words = randomScripture.GetText().Split(' ');

            // Create a loop that allows the user to hide words
            while (input.ToLower() != "quit" && !randomScripture.IsAllWordsHidden())
            {
                // Choose a random word to hide
                int wordIndex = rand.Next(0, words.Length);
                
                // If the word is not already hidden, add it to the list of hidden words
                if (!randomScripture.hiddenWords.Contains(wordIndex))
                {
                    randomScripture.hiddenWords.Add(wordIndex);
                }

                Console.Clear();
                Console.WriteLine(randomScripture.GetReference());
                // Loop through the words in the scripture, displaying each one with either its text or asterisks
                for (int i = 0; i < words.Length; i++)
                {
                    if (randomScripture.hiddenWords.Contains(i))
                    {
                        Console.Write(new string('*', words[i].Length));
                    }
                    else
                    {
                        Console.Write(words[i]);
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide another word, or type 'quit' to exit.");
                input = Console.ReadLine();
            }

            // Reset the hidden words for the next scripture
            randomScripture.ResetHiddenWords();
        }
    }
}