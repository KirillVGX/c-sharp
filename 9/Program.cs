class Program {
    static void Main() {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());

        double result = Calculator.Compute(x, y);
        Console.WriteLine($"Результат: {result:F3}");
    }
}