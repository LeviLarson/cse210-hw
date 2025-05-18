using System;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder(); //https://stackoverflow.com/questions/779051/string-concatenation-unsafe-in-c-need-to-use-stringbuilder
        sb.AppendLine("Packing Label:");
        foreach (Product product in _products)
        {
            sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}