class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }
        return totalPrice + customer.GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"Product ID: {product.Id}\tName: {product.Name}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress:\n{customer.Address.GetAddressString()}";
    }
}