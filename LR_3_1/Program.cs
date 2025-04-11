using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y:");
            double y = double.Parse(Console.ReadLine());
            double z = Function.max(x,2 * y + x) - Function.max(7 * x +  2 * y, y); 
            Console.WriteLine(z);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректные числовые значения.");
        }
    }
}