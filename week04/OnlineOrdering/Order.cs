using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        double shipping;
        foreach (Product item in _products)
        {
            total += item.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        double totalCost = total + shipping;
        return  totalCost;
    }

    public void PackagingLabel()
    {
        Console.WriteLine($"ITEM NAME       PRODUCT ID        QUANTITY     COST");
        foreach (Product item in _products)
        {
           Console.WriteLine($"{item.GetProductDetails()}"); 
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.GetCustomersName()}\n {_customer.GetCustomerAddress()}");
    }
}