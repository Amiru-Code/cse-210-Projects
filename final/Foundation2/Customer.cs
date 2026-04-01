public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
        return _address.isInUSA();
    }

    public string GetCustomerName() => _name;
    public Address GetCustomerAddress() => _address;
}