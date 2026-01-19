// dotnet run --project "C:\Users\Користувач\Desktop\C#labs\C#labs.csproj"

using System;

class BrandedProduct : Product {
    protected string brand;

    public BrandedProduct(string n, double p, int y, string b) : base(n, p, y) {
        brand = b;
    }

    public void AddBonusPrice(string targetBrand) {
        if (brand == targetBrand) {
            price *= 1.1;
        }
    }

    public override void ShowInfo() {
        base.ShowInfo();
        Console.WriteLine($"Бренд: {brand}");
    }
}

static class ProductHelper {
    public static int GetYearsAgo(Product p) {
        return DateTime.Now.Year - p.GetYear();
    }
}

class Program {
    static void Main() {
        Console.Write("Введіть назву товару: ");
        string name = Console.ReadLine();

        Console.Write("Введіть ціну товару: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Введіть рік випуску: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Введіть бренд: ");
        string brand = Console.ReadLine();

        BrandedProduct product = new BrandedProduct(name, price, year, brand);

        Console.WriteLine("\nПочаткова інформація:");
        product.ShowInfo();

        product.ReducePrice();
        product.AddBonusPrice("Lenovo");

        Console.WriteLine("\nПісля перевірки знижок:");
        product.ShowInfo();

        int yearsAgo = ProductHelper.GetYearsAgo(product);
        Console.WriteLine($"\nТовар був випущений {yearsAgo} років тому.");
    }
}