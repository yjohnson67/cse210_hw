// Derived class for receptions
public class Reception : Event
{
    // Private field to store the RSVP email for the reception
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }
    
    public override string GetFullDetails()
    {
         // Return the full details of the reception, including the base event details and the RSVP email
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}