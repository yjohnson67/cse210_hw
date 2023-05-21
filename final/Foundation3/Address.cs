// Address class
public class Address
{
    // Private field to store the street address
    private string street;
    // Private field to store the city
    private string city;
    // Private field to store the state
    private string state;
    // Private field to store the zip code
    private string zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public override string ToString()
    {
         // Return a formatted string representation of the address, including the street, city, state, and zip code
        return $"{street}, {city}, {state}, {zipCode}";
    }
}