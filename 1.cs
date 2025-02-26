using System;

namespace ConsoleApp6
{
class Product
{
    public string name;
    public double price;
    public int col;
    public Product(string new_name, double new_price, int new_col)
    {
        name = new_name;
        price = new_price;
        col = new_col;
    }

    public double Cost()
    {
        return price * col;
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product("Kiwi", 15.99, 42);
        Console.WriteLine($"Total cost {product.name}: {product.Cost()}");
    }
}
}