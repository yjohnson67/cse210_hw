class Address
{
    private string street;// Private field to store the street address
    private string city;// Private field to store the city
    private string state;// Private field to store the state
    private string country;// Private field to store the country

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string Street { get { return street; } }// Public property to access the street address
    public string City { get { return city; } }// Public property to access the city
    public string State { get { return state; } }// Public property to access the state
    public string Country { get { return country; } }// Public property to access the country

    public bool IsInUSA()
    {
        // Check if the address is in the USA by comparing the country to "USA"
        return country == "USA";
    }

    public string GetAddressString()
    {
        // Return a formatted string representation of the address
        return $"{street}\n{city}, {state}\n{country}";
    }
}