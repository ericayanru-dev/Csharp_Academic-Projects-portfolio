public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA" || _country == "usa" || _country == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Display()
    {
        return $"{_address}\n {_city} {_state}\n {_country}";
    }
}