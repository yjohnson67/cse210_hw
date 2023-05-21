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
        // Add a product to the order
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        // Calculate the total price by summing the prices of all products in the order
        foreach (Product product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }
         // Add the shipping cost to the total price
        return totalPrice + customer.GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "";
        // Generate a packing label for the order, including product details
        foreach (Product product in products)
        {
            label += $"Product ID: {product.Id}\tName: {product.Name}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        // Generate a shipping label for the order, including customer details and address
        return $"Customer: {customer.Name}\nAddress:\n{customer.Address.GetAddressString()}";
    }
}