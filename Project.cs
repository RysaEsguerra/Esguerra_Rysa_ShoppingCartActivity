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

                switch (choice)
                {
                    case 1:
                        if (p1.Stock == 0)
                        {
                            Console.WriteLine("Watermelon is out of stock.");
                        }
                        else if (qty > p1.Stock)
                        {
                            Console.WriteLine("Not enough stock.");
                        }
                        else
                        {
                            qty1 += qty;
                            p1.Stock -= qty;
                            Console.WriteLine("Watermelon added to cart!");
                        }
                        break;

                    case 2:
                        if (p2.Stock == 0)
                        {
                            Console.WriteLine("Peach is out of stock.");
                        }
                        else if (qty > p2.Stock)
                        {
                            Console.WriteLine("Not enough stock.");
                        }
                        else
                        {
                            qty2 += qty;
                            p2.Stock -= qty;
                            Console.WriteLine("Peach added to cart!");
                        }
                        break;

                    case 3:
                        if (p3.Stock == 0)
                        {
                            Console.WriteLine("Melon is out of stock.");
                        }
                        else if (qty > p3.Stock)
                        {
                            Console.WriteLine("Not enough stock.");
                        }
                        else
                        {
                            qty3 += qty;
                            p3.Stock -= qty;
                            Console.WriteLine("Melon added to cart!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product.");
                        continue;
                }

                Console.Write("Add more items? (Y/N): ");
                again = Console.ReadLine().ToUpper();
            }

            double total = 0;

            Console.WriteLine("\n=== RECEIPT ===");

            if (qty1 > 0)
            {
                double sub = p1.GetTotal(qty1);
                total += sub;
                Console.WriteLine($"Watermelon x{qty1} = ₱{sub}");
            }
            if (qty2 > 0)
            {
            double sub = p2.GetTotal(qty2);
            total += sub;
            Console.WriteLine($"Peach x{qty2} = ₱{sub}");
            }

            if (qty3 > 0)
            {
            double sub = p3.GetTotal(qty3);
            total += sub;
            Console.WriteLine($"Melon x{qty3} = ₱{sub}");
            }
             Console.WriteLine("----------------------");
             Console.WriteLine("Grand Total: ₱" + total);

            double discount = 0;
            if (total >= 5000)
            {
            discount = total * 0.10;
            } 
    
            double finalTotal = total - discount
                        Console.WriteLine("Discount: ₱" + discount);
            Console.WriteLine("Final Total: ₱" + finalTotal);

            Console.WriteLine("\n=== UPDATED STOCK ===");
            p1.DisplayProduct();
            p2.DisplayProduct();
            p3.DisplayProduct();

            Console.Write("\nNext customer? (Y/N): ");
            nextCustomer = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("\nStore closed.");
    }
}
