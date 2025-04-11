using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите дату (дд.ММ.гггг): ");
        string input = Console.ReadLine();
        Console.WriteLine($"День недели: {Function.GetDay(input)}");

        try
        {
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            int days = Function.GetDaysSpan(day, month, year);

            if (days == int.MinValue)
                Console.WriteLine("Ошибка: введена некорректная дата.");
            else
                Console.WriteLine($"Количество дней до указанной даты: {days}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректные числовые значения.");
        }
    }
}