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
         int qty1 = 0, qty2 = 0, qty3 = 0;
 double total = 0;
 string again = "Y";

 while (again == "Y")
 {
     Console.WriteLine("\n==== STORE MENU ====");
     p1.Display();
     p2.Display();
     p3.Display

     Console.Write("Enter product number: ");
if (!int.TryParse(Console.ReadLine(), out int choice))
{
    Console.WriteLine("Invalid input.");
    continue;
}

Console.Write("Enter quantity: ");
if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
{
    Console.WriteLine("Invalid quantity.");
    continue;
}


