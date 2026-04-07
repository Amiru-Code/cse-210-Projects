public class Address
{
    private string _street;
    private string _zip;
    private string _city;
    private string _state;

    public Address(string street, string city, string zip, string state)
    {
        _street = street;
        _city = city;
        _zip = zip;
        _state = state;
    }


    public string GetFullAddress()
    {
        return $"{_street}, {_zip}, {_city}, {_state}";
    }
}