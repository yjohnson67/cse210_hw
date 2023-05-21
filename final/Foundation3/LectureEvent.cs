class LectureEvent : Event
{
    // Public property to store the name of the speaker
    public string Speaker { get; set; }
    // Public property to store the capacity of the lecture event
    public int Capacity { get; set; }

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        // Return the full details of the lecture event, including the base event details, lecture-specific details, speaker, and capacity
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        // Return a short description of the lecture event, including the base event description and lecture-specific details
        return $"{base.GetShortDescription()}\nType: Lecture";
    }
}