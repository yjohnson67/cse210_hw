// Import the System namespace
using System;

// Define a class called Program
class Program
{
    // Define the Main method, which is the entry point of the program
    static void Main(string[] args)
    {
        // Create a new instance of the Journal class
        Journal journal = new Journal();
        // Initialize a variable called "option" to 0
        int option = 0;

        // Create a loop that runs until the user chooses to exit
        while (option != 5)
        {
            // Display a menu of options to the user
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit program");

            // Read the user's choice from the console and convert it to an integer
            option = Convert.ToInt32(Console.ReadLine());

            // Use a switch statement to determine which action to take based on the user's choice
            switch (option)
            {
                case 1:
                    journal.Write();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.Save();
                    break;
                case 4:
                    journal.Load();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    // Return from the Main method to exit the program
                    return;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}