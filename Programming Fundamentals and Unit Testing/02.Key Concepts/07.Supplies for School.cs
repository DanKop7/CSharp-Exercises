using System;

class Program
{
    static void Main()
    {
        int pensPack = int.Parse(Console.ReadLine());
        int markerPack = int.Parse(Console.ReadLine());
        int literCleaner = int.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine()) / 100;

        double pensPrice = 5.80;
        double markerPrice = 7.20;
        double cleanerPriceLiter = 1.20;

        double totalPens = pensPack * pensPrice;
        double totalMarker = markerPack * markerPrice;
        double totalCleaner = literCleaner * cleanerPriceLiter;

        double totalPrice = totalPens + totalMarker + totalCleaner;
        double finalPrice = totalPrice - (totalPrice * discount);

        Console.WriteLine(finalPrice);
    }
}
