class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get { return name; } }
    public string Id { get { return id; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }
}