// Import the System and System.Collections.Generic namespaces
using System;
using System.Collections.Generic;

// Define a class called PromptGenerator
class PromptGenerator
{
    // Declare a private field called prompts, which is a List of strings
    private List<string> prompts;

  // Define a constructor for the PromptGenerator class
    public PromptGenerator()
    {
        // Initialize the prompts field with four default prompts
        prompts = new List<string>();
        prompts.Add("What did you learn today?");
        prompts.Add("How did you feel about your progress this week?");
        prompts.Add("What challenges did you face today and how did you overcome them?");
        prompts.Add("What are your goals for the upcoming week?");
    }

// Define a method called GetRandomPrompt, which returns a random prompt from the prompts list
    public string GetRandomPrompt()
    {
        // Create a new Random object
        Random rnd = new Random();
        // Generate a random index between 0 and the number of prompts in the list
        int index = rnd.Next(prompts.Count);
        // Return the prompt at the randomly generated index
        return prompts[index];
    }
}