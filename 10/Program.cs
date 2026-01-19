using System;

class Program {
    static double Quad(double x) {
        return (x - 1.6) * (x - 1.6); 
    }

    static double F(double x) {
        return (x - 1) * Math.Sin(x * x + 1) - Math.Pow(2, 0.25);
    }

    static void Main() {
        double eps = 0.001;
        myDelegate testFunc = new myDelegate(Quad);
        double xTest = FindMinimum.Find(testFunc, 0, 5, eps);

        Console.WriteLine("Тестування на квадратичній функції:");
        Console.WriteLine($"Числовий мінімум: x = {xTest:F7}");
        Console.WriteLine("Аналітичний мінімум: x = 2.00");
        Console.WriteLine($"Різниця = {Math.Abs(xTest - 1.6)}");

        double a = 2.7;
        double b = 3.3;

        myDelegate func = new myDelegate(F);
        double xmin = FindMinimum.Find(func, a, b, eps);

        Console.WriteLine($"Точка мінімуму для функції: x = {xmin}");
        Console.WriteLine($"Значення F(xmin) = {F(xmin)}");
    }
}