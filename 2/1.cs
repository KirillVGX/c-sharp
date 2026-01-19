using System;

class Program
{
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static int Sum(int[] arr)
    {
        int s = 0;
        for (int i = 0; i < arr.Length; i++)
            s += arr[i];
        return s;
    }

    static double[] MakeB(int[] a)
    {
        int n = a.Length;
        int total = Sum(a);
        double[] b = new double[n];
        for (int i = 0; i < n; i++)
            b[i] = (double)(total - a[i]) / (n - 1);
        return b;
    }

    static void Main()
    {
        int N = 20;
        int[] a = new int[N];
        Random rnd = new Random();
        for (int i = 0; i < N; i++)
            a[i] = rnd.Next(-9, 10); // від -50 до 50

        double[] b = MakeB(a);

        Console.WriteLine("Масив a:");
        Print(a);
        Console.WriteLine("Масив b:");
        Print(Array.ConvertAll(b, x => (int)Math.Round(x))); // округлив для зручності
    }
}