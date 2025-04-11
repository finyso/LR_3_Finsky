using System;

public class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"№6. 2/3*sin^2(x) - 3/4*cos^2(x) = {Function.result(x)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректные числовые значения.");
        }
    }
}