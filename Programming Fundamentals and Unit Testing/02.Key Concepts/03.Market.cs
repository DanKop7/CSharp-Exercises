using System;

class Program
{
    static void Main()
    {
        double tomatoPrice = double.Parse(Console.ReadLine());
        double tomatoQuantity = double.Parse(Console.ReadLine());
        double cucumberPrice = double.Parse(Console.ReadLine());
        double cucumberQuantity = double.Parse(Console.ReadLine());

        double totalTomato = tomatoPrice * tomatoQuantity;
        double totalCucumber = cucumberPrice * cucumberQuantity;
        double totalPrice = totalTomato + totalCucumber;

        Console.WriteLine($"{totalPrice:F2}");
    }
}
