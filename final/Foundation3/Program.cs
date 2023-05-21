using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of each event type
        Address lectureAddress = new Address("123 Main St", "New York", "NY", "10001");
        LectureEvent lecture = new LectureEvent("Tech Talk", "Learn about the latest technologies", new DateTime(2023, 5, 20), new TimeSpan(14, 0, 0), lectureAddress, "John Doe", 100);

        Address receptionAddress = new Address("456 Park Ave", "San Francisco", "CA", "94101");
        Reception reception = new Reception("Networking Event", "Join us for a networking event", new DateTime(2023, 5, 25), new TimeSpan(18, 30, 0), receptionAddress, "rsvp@example.com");

        Address gatheringAddress = new Address("789 Beach Rd", "Miami", "FL", "33101");
        OutdoorGathering gathering = new OutdoorGathering("Beach Party", "Celebrate summer with a beach party", new DateTime(2023, 6, 1), new TimeSpan(12, 0, 0), gatheringAddress, "Sunny with a slight breeze");

        // Generate marketing messages for each event
        Console.WriteLine("Event Marketing Messages:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        // Marketing messages for Reception event
        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        // Marketing messages for Outdoor Gathering event
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}