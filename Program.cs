using ConsoleApp2;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Toy("Action Figure"),
            new Meat("Chicken"),
            new Drinks("500ml"),
            new Clothing("M"),
            new Electronics("2 years")
        };

        decimal discountPercentage = 0.1m;

        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetInformation()}, Цена без скидки: {product.Price:C}");
        }
        Console.WriteLine();
        foreach (Product product in products)
        {
            decimal discountedPrice = product.Price * (1 - discountPercentage);
            Console.WriteLine($"{product.GetInformation()}, Цена со скидкой: {discountedPrice:C}");
        }
    }
}