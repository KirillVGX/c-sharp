using System;

class Triangle {
    private double katet1;
    private double katet2;

    // Конструктор без параметрів
    public Triangle() {
        katet1 = 0;
        katet2 = 0;
    }

    // Конструктор з параметрами
    public Triangle(double k1, double k2) {
        katet1 = k1;
        katet2 = k2;
    }

    // Метод для введення даних
    public void Input() {
        Console.Write("Введіть перший катет: ");
        katet1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть другий катет: ");
        katet2 = Convert.ToDouble(Console.ReadLine());
    }

    // Метод для показу інформації
    public void Print() {
        Console.WriteLine("Катeт 1 = " + katet1 + ", Катeт 2 = " + katet2);
    }

    // Метод для обчислення периметра
    public double Perimeter() {
        double gipotenuza = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));
        return katet1 + katet2 + gipotenuza;
    }
}

class Program {
    static void Main() {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle(3, 4);

        Console.WriteLine("Введення для першого трикутника:");
        t1.Input();

        Console.WriteLine("\nПерший трикyтник:");
        t1.Print();
        Console.WriteLine("Пeриметр = " + t1.Perimeter());

        Console.WriteLine("\nДругий трикyтник:");
        t2.Print();
        Console.WriteLine("Пeриметр = " + t2.Perimeter());
    }
}