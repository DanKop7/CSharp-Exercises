using System;

class Program
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int hourPages = int.Parse(Console.ReadLine());
        int daysToFinish = int.Parse(Console.ReadLine());

        int readingTime = bookPages / hourPages;
        int hoursPerDay = readingTime / daysToFinish;

        Console.WriteLine(hoursPerDay);
    }
}
