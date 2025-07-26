using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Apple Street", "Cupertino", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("iPad", "P001", 500, 2);
        Product product2 = new Product("Apple Pencil", "P002", 120, 1);

        Order order1 = new Order(customer1);
        order1.SetProduct(product1);
        order1.SetProduct(product2);
        Console.WriteLine("Order 1 Packing Label:");
        order1.PackagingLabel();
        Console.WriteLine("\nOrder 1 Shipping Label:");
        order1.ShippingLabel();
        Console.WriteLine($"\nOrder 1 Total Price: ${order1.CalculateTotalCost()}");


        Address address2 = new Address("456 Orange Avenue", "London", "England", "UK");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Kindle", "P003", 150, 1);
        Product product4 = new Product("Cover Case", "P004", 30, 2);

        Order order2 = new Order(customer2);
        order2.SetProduct(product3);
        order2.SetProduct(product4);

        Console.WriteLine("\nOrder 2 Packing Label:");
        order2.PackagingLabel();
        Console.WriteLine("\nOrder 2 Shipping Label:");
        order2.ShippingLabel();
        Console.WriteLine($"\nOrder 2 Total Price: ${order2.CalculateTotalCost()}");
    }
}