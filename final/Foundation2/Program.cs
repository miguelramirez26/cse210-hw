using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("T-Shirt", "Essentials-1675", 25, 3);
        Address address1 = new Address("1234 Oak Street", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("Mike Ramirez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.PackingLabel();
        Console.WriteLine($"Shipping: ${order1.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order1.OrderTotal()}");
        order1.ShippingLabel(customer1);

        Console.WriteLine();
        Console.WriteLine($"---------------------");
        Product product2 = new Product("Track Pants", "Essentials-1789", 65, 1);
        Product product3 = new Product("Windbreaker", "Essentials-1333", 35, 1);
        Address address2 = new Address("123 Main Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jeff Martinez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.PackingLabel();
        Console.WriteLine($"Shipping: ${order2.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order2.OrderTotal()}");
        order2.ShippingLabel(customer2);
    }
}