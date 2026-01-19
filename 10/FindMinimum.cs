using System;

public delegate double myDelegate(double x);

public static class FindMinimum {
    public static double Find(myDelegate f, double a, double b, double eps) {
        // 1
        double x = a;
        double h = (b - a) / 10.0;
        double G = f(x);

        while (Math.Abs(h) > eps / 4.0) {
            // 2
            double xNext = x + h;

            if (xNext < a || xNext > b) {
                h = -h / 4.0;
                continue;
            }

            double Fnext = f(xNext);

            // 3
            if (Fnext < G) {
                x = xNext;
                G = Fnext;
            }
            // 4
            else {
                h = -h / 4.0;
            }
        }

        return x;
    }
}