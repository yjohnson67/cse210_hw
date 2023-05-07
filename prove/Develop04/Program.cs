using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            choice = int.Parse(Console.ReadLine());

            Activity selectedActivity;

            switch (choice)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    selectedActivity.PerformActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectionActivity();
                    selectedActivity.PerformActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    selectedActivity.PerformActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    // Exit the program
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    // Continue the loop to ask for a valid choice
                    continue;
            }

        } while (true);
    }
}