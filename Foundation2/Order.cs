using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Calculate the total price of the order
    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    // Get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    // Get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.FullAddress()}";
    }
}
