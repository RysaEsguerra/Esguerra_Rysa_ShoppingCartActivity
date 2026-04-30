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




------------------Enhance Shopping Cart Activity-----------------

    using System;

class Product
{
    public int Id;
    public string Name;
    public string Category;
    public double Price;
    public int Stock;

    public Product(int id, string name, string category, double price, int stock)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
        Stock = stock;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{Id}. {Name} - {Category} - ₱{Price} - Stock: {Stock}");
    }

    public bool HasEnoughStock(int qty)
    {
        return Stock >= qty;
    }

    public void DeductStock(int qty)
    {
        Stock -= qty;
    }
}
class CartItem
{
    public Product Product;
    public int Quantity;

    public CartItem(Product p, int q)
    {
        Product = p;
        Quantity = q;
    }

    public double Subtotal()
    {
        return Product.Price * Quantity;
    }
}

class Order
{
    public string ReceiptNo;
    public DateTime DateTime;
    public CartItem[] Items;
    public int ItemCount;
    public double GrandTotal;
    public double Discount;
    public double FinalTotal;
    public double Payment;
    public double Change;
}

class Program
{
    static Product[] products = new Product[]
    {
        new Product(1,"Burger","Food",100,10),
        new Product(2,"Mouse","Electronics",500,10),
        new Product(3,"Keyboard","Electronics",800,10),
        new Product(4,"T-Shirt","Clothing",300,10)
    };

    static CartItem[] cart = new CartItem[10];
    static int cartCount = 0;

    static Order[] orders = new Order[10];
    static int orderCount = 0;

    static int receiptCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("3. Filter Category");
            Console.WriteLine("4. Add to Cart");
            Console.WriteLine("5. Cart Menu");
            Console.WriteLine("6. Order History");
            Console.WriteLine("7. Exit");

            int choice = ReadInt("Choose: ", 1, 7);

            if (choice == 1) ViewProducts();
            else if (choice == 2) SearchProduct();
            else if (choice == 3) FilterCategory();
            else if (choice == 4) AddToCart();
            else if (choice == 5) CartMenu();
            else if (choice == 6) OrderHistory();
            else break;
        }
    }




