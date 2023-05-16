class LectureEvent : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public LectureEvent(string title, string description, DateTime date, string address, string speaker, int capacity)
        : base(title, description, date, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public string GetShortDescription()
    {
        return $"Type: Lecture\nEvent: {Title}\nDate: {Date}";
    }
}