using System;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string[] items; // Array to store the listed items

    public ListingActivity() : base("Listing Activity")
    {
        items = new string[0];
    }

    public override void PerformActivity()
    {
        // Call the Start method from the base class
        Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("\nGet ready to start...");
        ShowCountdown(3); // Countdown for 3 seconds before starting the activity

        Console.WriteLine("\nTime to respond:");

        DateTime endTime = DateTime.Now.AddSeconds(duration); // Calculate the end time based on the duration
        while (DateTime.Now < endTime)
        {
            // Accept user input during the response time
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                // Resize the items array to accommodate the new item
                Array.Resize(ref items, items.Length + 1);
                // Add the new item to the end of the array
                items[items.Length - 1] = item;
            }
        }

        Console.WriteLine("\nTime's up!");

        End();
    }

    protected override void Start()
    {
        base.Start();
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected override void End()
    {
        base.End();
        Console.WriteLine("\nYour list:");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
        Console.WriteLine($"\nWell done! You listed {items.Length} items.");
        ShowCountdown(3); // Countdown for 3 seconds before ending the activity
    }

    protected void ShowCountdown(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int millisecondsPerFrame = 250;
        int frames = seconds * 1000 / millisecondsPerFrame;

        for (int i = 0; i < frames; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(millisecondsPerFrame);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.WriteLine();
    }
}