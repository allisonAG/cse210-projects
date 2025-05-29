public class Customer
{
    private string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool livesInUSA()
    {
        return _address.isIntheUSA();
    }

    public string GetShippingLabel()
    {
        return $"Name: {_name}, Address: {_address.GetFullAddress()}";
    }
}