using System;

class Program
{
    static void Main()
    {
        const int n = 3, m = 4;
        int[,] a = new int[n, m] {
            {1, 2,  3,  4},
            {5, 6,  7,  8},
            {9, 10, 11, 12}
        };

        for (int j = 0; j < m; j += 2)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i, j];

            Console.WriteLine($"Стовпець {j}: {sum / n}");
        }
    }
}