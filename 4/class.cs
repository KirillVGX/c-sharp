using System;

class Product {
    protected string name;
    protected double price;
    protected int year;

    public Product() {
        name = "";
        price = 0;
        year = 0;
    }

    public Product(string n, double p, int y) {
        name = n;
        price = p;
        year = y;
    }

    public void SetData(string n, double p, int y) {
        name = n;
        price = p;
        year = y;
    }

    public void ReducePrice() {
        int yearsOld = DateTime.Now.Year - year;
        if (yearsOld > 5) {
            price -= price * 0.1;
        }
    }

    public virtual void ShowInfo() {
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Ціна: {price:F2}");
        Console.WriteLine($"Рік випуску: {year}");
    }

    public string GetName() { return name; }
    public double GetPrice() { return price; }
    public int GetYear() { return year; }
    public void SetPrice(double p) { price = p; }
}