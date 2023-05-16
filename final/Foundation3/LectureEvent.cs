class LectureEvent : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"{base.GetShortDescription()}\nType: Lecture";
    }
}