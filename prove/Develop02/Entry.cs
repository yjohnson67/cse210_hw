// Define a class called Entry
class Entry
{
    // Declare private fields for the date, prompt, and response, and a publi property for the mood
    string date, prompt, response;
    public string Mood { get; set; }

    public Entry(string _date, string _prompt, string _response, string _mood)
    {
        // Assign the values of the arguments to the corresponding fields and property
        date = _date;
        prompt = _prompt;
        response = _response;
        Mood = _mood;
    }

// Define a method called DisplayEntry that writes the values of the fields and property to the console
    public void DisplayEntry()
    {
        Console.WriteLine("{0}\nPrompt: {1}\nResponse: {2}\nMood: {3}", date, prompt, response, Mood);
    }

// Define a method called getEntryAsCSV that returns the values of the fields and property as a formatted string
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}", date, prompt, response, Mood);
    }
}