using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Shopping Cart System");
    }
}
class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Stock;
    public void Display()
    {
        Console.WriteLine($"{Id}. {Name} - ₱{Price} (Stock: {Stock})");
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product { Id = 1, Name = "Watermelon", Price = 70, Stock = 10 };
        Product p2 = new Product { Id = 2, Name = "Peach", Price = 15, Stock = 20 };
        Product p3 = new Product { Id = 3, Name = "Melon", Price = 50, Stock = 5 };

        string nextCustomer = "Y";

