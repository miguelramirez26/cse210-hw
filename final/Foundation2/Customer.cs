using System;

class Customer
{
    // Attributes
    private string _customerName;
    public Address _address;

    // Constructors
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    // Methods
    public bool CheckAddressUSA()
    {
        return _address.InUSA();
    }
    public void DisplayCustomer()
    {
        Console.WriteLine();
        Console.WriteLine($"{_customerName}");
        Console.WriteLine(_address.CustomerAddress());
    }
}