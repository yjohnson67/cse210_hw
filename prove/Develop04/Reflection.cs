using System;
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random rand = new Random();
    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n!") {Console.WriteLine("Welcome to the Reflection Activity!"); }

    // Perform the reflection activity
    public override void PerformActivity()
    {
        // Call the Start method from the base class
        Start();
       //Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        int elapsedTime = 0;
        Random rand = new Random();

        while (elapsedTime < duration)
        {
            // Randomly select a prompt from the array
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine("When you have something in mind, press enter to continue...");
            Console.ReadLine();
            // Show the countdown for 10 seconds
            ShowCountdown(10);
            // Increment the elapsed time by 10 seconds
            elapsedTime += 10;

            // Select two random questions from the list
            string question1 = GetRandomQuestion();
            string question2 = GetRandomQuestion();

            Console.WriteLine(question1);
            SpinnerAnimation(5);

            Console.WriteLine(question2);
            SpinnerAnimation(5);

            // Check if the elapsed time is equal to or greater than the duration
            //if (elapsedTime >= duration)
           // {
                break; // Exit the loop
           // }
        }

        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed a {duration} second session of the Reflection Activity.");

        // Call the End method from the base class
        End();
    }


    // Get a random question from the list and remove it
    private string GetRandomQuestion()
    {
        int index = rand.Next(reflectionQuestions.Count);
        string question = reflectionQuestions[index];
        reflectionQuestions.RemoveAt(index);
        return question;
    }


    // Start the reflection activity
    protected override void Start()
    {
        Console.WriteLine($"{name}\n");
        Console.Write("Enter the duration of the activity in seconds: ");
        // Set the duration based on user input
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to start...");
        // Show the countdown for 3 seconds before starting the activity
        ShowCountdown(3);
    }

    // End the reflection activity
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

    protected void SpinnerAnimation(int seconds)
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
}