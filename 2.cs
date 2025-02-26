using System;

namespace ConsoleApp6
{
class Trelugl
{
    public double w;
    public double h;

    public Trelugl(double new_w, double new_h)
    {
        w = new_w;
        h = new_h;
    }
    public double Ploshad()
    {
        return w * h;
    }
    public double Perimeter()
    {
        return 2 * (w + h);
    }
}
class Program
{
    static void Main()
    {
        Trelugl trelugl = new Trelugl(5, 10);
        Console.WriteLine($"S: {trelugl.Ploshad()}");
        Console.WriteLine($"P: {trelugl.Perimeter()}");
    }
}
}