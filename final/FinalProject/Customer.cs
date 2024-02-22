
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string ShippingAddress()
    {
        return $"{_name} {_address.FullAddress()}";
    }
    public bool IsUSA ()
    {
        return _address.IsUSA();
    }
}