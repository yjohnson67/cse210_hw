class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string State { get { return state; } }
    public string Country { get { return country; } }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetAddressString()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}