using System;
// Derived class for outdoor gatherings
public class OutdoorGathering : Event
{
    // Private field to store the weather statement for the outdoor gathering
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        // Return the full details of the outdoor gathering, including the base event details and the weather statement
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weatherStatement}";
    }
}