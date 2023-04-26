using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>();
        prompts.Add("What did you learn today?");
        prompts.Add("How did you feel about your progress this week?");
        prompts.Add("What challenges did you face today and how did you overcome them?");
        prompts.Add("What are your goals for the upcoming week?");
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        return prompts[index];
    }
}