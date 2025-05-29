using System.Numerics;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _customer;

    public Order(Customer customer)
    {
    _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.livesInUSA())
        {
            return total + 5;
        }

        return total + 35;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"\nPacking Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetPackingLabel());
        }

    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"\nShipping Label:");
        Console.WriteLine(_customer.GetShippingLabel());
    }
    
    public void DisplayTotalPrice()
    {
        Console.WriteLine($"\nTotal Price: ${GetTotalPrice()}");
    }

}