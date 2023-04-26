using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit program");

            option = Convert.ToInt32(Console.ReadLine());

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
                    return;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}