public class Address
{
    private string _street;
    private string _zip;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string zip, string state, string country)
    {
        _street = street;
        _city = city;
        _zip = zip;
        _state = state;
        _country = country;
    }

    public bool isInUSA()
    {
        if(_country.ToLower().Equals("united states of america") == true || _country.ToLower().Equals("united states") == true || _country.ToLower().Equals("america"))
        {
            return true;
        }
        else
        return false;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_zip}, {_city}, {_state}, {_country}";
    }
}