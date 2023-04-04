using System;

class Product
{
    // Attributes
    private string _productName;
    private string _ID;
    private int _price;
    private int _quantity;

    // Constructors
    public Product(string name, string ID, int price, int quantity)
    {
        _productName = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public int ProductFee()
    {
        return (_price * _quantity);
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"'{_ID}'     {_productName}");
        Console.Write($"{_quantity} @ ${_price}      ");
        Console.WriteLine($"${ProductFee()}");

    }
}