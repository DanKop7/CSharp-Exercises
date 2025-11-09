using System;

class Program
{
    static void Main()
    {
        int chickenMenuNumber = int.Parse(Console.ReadLine());
        int fishMenuNumber = int.Parse(Console.ReadLine());
        int vegetarianMenuNumber = int.Parse(Console.ReadLine());

        double chickenMenuPrice = 10.35;
        double fishMenuPrice = 12.40;
        double vegetarianMenuPrice = 8.15;
        double deliveryPrice = 2.50;

        double chickenPrice = chickenMenuNumber * chickenMenuPrice;
        double fishPrice = fishMenuNumber * fishMenuPrice;
        double vegetarianPrice = vegetarianMenuNumber * vegetarianMenuPrice;

        double totalCostMenu = chickenPrice + fishPrice + vegetarianPrice;
        double dessertPrice = totalCostMenu * 0.20;
        double totalCost = totalCostMenu + dessertPrice + deliveryPrice;

        Console.WriteLine(totalCost);
    }
}
