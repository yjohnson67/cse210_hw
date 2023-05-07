using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity") { }

    // Perform the breathing activity
    public override void PerformActivity()
    {
        // Call the Start method from the base class
        Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

        Console.WriteLine("Breathe in for 2 breaths...");
        CountdownAndShowProgress(4);

        Console.WriteLine("Breathe out for 4 breaths...");
        CountdownAndShowProgress(6);

        Console.WriteLine("Breathe in for 4 breaths...");
        CountdownAndShowProgress(6);

        Console.WriteLine("Breathe out for 6 breaths...");
        CountdownAndShowProgress(8);

        Console.WriteLine("Breathe in for 6 breaths...");
        CountdownAndShowProgress(8);

        Console.WriteLine("Breathe out for 8 breaths...");
        CountdownAndShowProgress(10);

        Console.WriteLine("\nWell done!");

        // Call the End method from the base class
        End();
    }

    // Start the breathing activity
    protected override void Start()
    {
        Console.WriteLine($"{name}\n");
        Console.WriteLine("\nGet ready to start...");
        // Show the countdown for 3 seconds before starting the activity
        ShowCountdown(3);
    }

    // End the breathing activity
    protected override void End()
    {
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        base.End();
    }

    // Display a countdown with a spinner animation
    protected void ShowCountdown(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int millisecondsPerFrame = 250;
        int frames = seconds * 1000 / millisecondsPerFrame;

        for (int i = 0; i < frames; i++)
        {
            // Display the spinner character
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(millisecondsPerFrame);
            // Move the cursor back one position
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            // Rotate to the next spinner character
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.WriteLine();
    }

    // Display a countdown with progress numbers
    protected void CountdownAndShowProgress(int breaths)
    {
        int countdownBreaths = breaths;
        int millisecondsPerBreath = 1000;
        int frames = countdownBreaths * 1000 / millisecondsPerBreath;

        for (int i = countdownBreaths; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(millisecondsPerBreath);
        }

        Console.WriteLine();
    }
}