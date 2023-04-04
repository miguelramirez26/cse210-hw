using System;

class Address
{
    // Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
            return false;
    }

    public string CustomerAddress()
    {
        string address = "";
        address += $"{_street}\n";
        address += $"{_city}\n";
        address += $"{_state}\n";
        address += $"{_country}\n";
        return address;
    }
}