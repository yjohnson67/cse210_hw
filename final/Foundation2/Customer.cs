class Customer
{
    private string name; // Private field to store the customer's name
    private Address address; // Private field to store the customer's address

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name { get { return name; } }// Public property to access the customer's name
    public Address Address { get { return address; } }// Public property to access the customer's address

    public bool IsInUSA()
    {
        // Check if the customer's address is in the USA by calling the IsInUSA() method on the address object
        return address.IsInUSA();

    }

    public double GetShippingCost()
    {
        // Return the shipping cost based on whether the customer's address is in the USA or not
        return address.IsInUSA()
        ? 5.0 : 35.0;
    }
}