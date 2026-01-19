using System;

public class Calculator {
    public static double Compute(double x, double y) {
        try {
            if (x - y < 0)
                throw new ArithmeticException("Корінь негативного числа.");

            double root = Math.Sqrt(x - y);  
            double result = root / y;   

            return result;
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Помилка: ділення на нуль.");
            return double.NaN;
        }
        finally {
            Console.WriteLine("Обчислення завершено.");
        }
    }
}