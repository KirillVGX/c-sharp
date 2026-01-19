using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int[] b = new int[n];
        int k = 0;
        for (int i = n - 1; i >= 0; i--)
            if (a[i] > 0) b[k++] = a[i];
        
        Console.Write("Виведені масиви:\n");

        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();

        for (int i = 0; i < k; i++)
            Console.Write(b[i] + " ");
    }
}