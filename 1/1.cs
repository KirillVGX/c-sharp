using System;

class Program
{
    static void Main()
    {
        double[] a = new double[20];
        for (int i = 0; i < 20; i++) 
            a[i] = i + 1; 

        double sum = 0;
        for (int i = 0; i < 20; i++) 
            sum += a[i];

        double[] b = new double[20];
        for (int i = 0; i < 20; i++)
            b[i] = (sum - a[i]) / 19;

        for (int i = 0; i < 20; i++) 
            Console.WriteLine(b[i]);
    }
}