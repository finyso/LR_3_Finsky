using System;

public class Function
{
    public static double result(double x)
    {
        if (x >= 0)
        {
            x = double.Sin(x);
            Console.WriteLine($"x >= 0, поэтому его значение изменяется на sin(x) = {x}");
        }
        return 2 * double.Pow(double.Sin(x), 2) / 3 - 3 * double.Pow(double.Cos(x), 2) / 4;
    }
}