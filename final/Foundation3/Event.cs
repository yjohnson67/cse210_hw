using System;
// Base class for all events
public class Event
{
    // Private field to store the event title
    private string title;
    // Private field to store the event description
    private string description;
    // Private field to store the event date
    private DateTime date;
    // Private field to store the event time
    private TimeSpan time;
    // Private field to store the event address
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        // Return a string containing the standard details of the event, including title, description, date, time, and address
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
    }

    public virtual string GetFullDetails()
    {
        // By default, return the standard details of the event
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        // Return a short description of the event, including the event type, title, and date
        return $"Type: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}