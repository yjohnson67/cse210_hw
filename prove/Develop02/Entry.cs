class Entry
{
    string date, prompt, response;
    public string Mood { get; set; }

    public Entry(string _date, string _prompt, string _response, string _mood)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
        Mood = _mood;
    }

    public void DisplayEntry()
    {
        Console.WriteLine("{0}\nPrompt: {1}\nResponse: {2}\nMood: {3}", date, prompt, response, Mood);
    }

    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}", date, prompt, response, Mood);
    }
}