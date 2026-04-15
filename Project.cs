using System;

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Stock;

    public void DisplayProduct()
    {
        Console.WriteLine($"{Id}. {Name} - ₱{Price} (Stock: {Stock})");
    }

    public double GetTotal(int qty)
    {
        return Price * qty;
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product { Id = 1, Name = "Watermelon", Price = 50, Stock = 10 };
        Product p2 = new Product { Id = 2, Name = "Peach", Price = 10, Stock = 20 };
        Product p3 = new Product { Id = 3, Name = "Melon", Price = 80, Stock = 5 };

        string nextCustomer = "Y";

        while (nextCustomer == "Y")
        {
            int qty1 = 0, qty2 = 0, qty3 = 0;
            string again = "Y";

            while (again == "Y")
            {
                Console.WriteLine("\n=== STORE MENU ===");
                p1.DisplayProduct();
                p2.DisplayProduct();
                p3.DisplayProduct();

