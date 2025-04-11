using System;
using System.Globalization;

public class Function
{
    public static string GetDay(string date)
    {
        try
        {
            DateTime day = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            return day.ToString("dddd", CultureInfo.GetCultureInfo("ru-RU"));
        }
        catch (FormatException)
        {
            return "Ошибка: неверный формат даты (ожидается dd.MM.yyyy)";
        }
    }
    
    public static int GetDaysSpan(int day, int month, int year)
    {
        try
        {
            DateTime targetDate = new DateTime(year, month, day);
            DateTime today = DateTime.Today;
            return (targetDate - today).Days;
        }
        catch (ArgumentOutOfRangeException)
        {
            return int.MinValue;
        }
    }
}