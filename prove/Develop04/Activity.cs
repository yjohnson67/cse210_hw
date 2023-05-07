using System;

public abstract class Activity
{
    // The duration of the activity in seconds
    protected int duration; 
    // An array of questions
    protected string name; 
    // An array of questions related to the activity
    protected string[] questions; 

    public Activity(string name)
    {
        this.name = name;
        // Initialize the questions array with length 0
        questions = new string[0]; 
    }

    public virtual void PerformActivity()
    {
        // Call the Start method
        Start(); 
        // Call the End method
        End(); 
    }

    protected virtual void Start()
    {
        // Display a message indicating the start of the activity
        Console.WriteLine($"Starting {name}...");
    }

    protected virtual void End()
    {
        // Display a message indicating the end of the activity
        Console.WriteLine($"Ending {name}...");
    }
}