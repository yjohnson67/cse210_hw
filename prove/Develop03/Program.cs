using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        // create a list of Scripture objects
        List<Scripture> scriptures = new List<Scripture>();

        // add three Scripture objects to the list
        scriptures.Add(new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
        scriptures.Add(new Scripture("Psalm", 23, 1, "The Lord is my shepherd, I lack nothing."));

        //create a new Random object
        Random rand = new Random();

        // iterate through each Scripture in the list   
        foreach (Scripture scripture in scriptures)
        {
            // clear the console window
            Console.Clear();

            // display the reference and text of the Scripture
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetText());

            // prompt the user to enter a command
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            // split the text of the Scripture into an array of words
            string[] words = scripture.GetText().Split(' ');

             // loop until the user enters 'quit' or all words are hidden
            while (input.ToLower() != "quit" && !scripture.IsAllWordsHidden())
            {
                // generate a random index for a word in the Scripture
                int wordIndex = rand.Next(0, words.Length);

                 // if the word at the index has not already been hidden
                if (!scripture.hiddenWords.Contains(wordIndex))
                {
                     // add the index to the list of hidden words
                    scripture.hiddenWords.Add(wordIndex);
                }

                // clear the console window
                Console.Clear();

                // display the reference and text of the Scripture, with hidden words replaced by asterisks
                Console.WriteLine(scripture.GetReference());
                for (int i = 0; i < words.Length; i++)
                {
                    if (scripture.hiddenWords.Contains(i))
                    {
                        Console.Write(new string('*', words[i].Length));
                    }
                    else
                    {
                        Console.Write(words[i]);
                    }
                    Console.Write(' ');
                }

                 // prompt the user to enter another command
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide another word, or type 'quit' to exit.");
                input = Console.ReadLine();
            }
        }
    }
}