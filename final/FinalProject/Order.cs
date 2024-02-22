
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }
    public void ShippingLabel()
    {
        Console.WriteLine(_customer.ShippingAddress());
    }
    public void PackagingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine(p.PackagingLabel());
        }
    }
    public int TotalCost()
    {
        int shippingCost = 35;
        if (_customer.IsUSA())
        {
            shippingCost = 5;
        }
        int totalCost = shippingCost;
        foreach (Product p in _products)
        {
            totalCost += p.TotalCost();
        }
        return totalCost;
    }
}