class Product
{
    private string name; // Private field to store the product name
    private string id; // Private field to store the product ID
    private double price; // Private field to store the product price
    private int quantity; // Private field to store the product quantity

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get { return name; } } // Public property to access the product name
    public string Id { get { return id; } } // Public property to access the product ID
    public double Price { get { return price; } } // Public property to access the product price
    public int Quantity { get { return quantity; } } // Public property to access the product quantity
}