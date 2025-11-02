using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountInNylonSqm = int.Parse(Console.ReadLine());
            int amountInPaintLiters = int.Parse(Console.ReadLine());
            int quantityOfThinnerLiters = int.Parse(Console.ReadLine());
            int hoursToDoTheWork = int.Parse(Console.ReadLine());

            double priceNylonSqm = 1.5;
            double pricePaintPerLiter = 14.50;
            double priceThinnerPerLiter = 5.0;
            double priceForBags = 0.4;

            double nylonAmount = (amountInNylonSqm + 2) * priceNylonSqm;
            double paintAmount = amountInPaintLiters * 1.1 * pricePaintPerLiter;
            double thinnerAmount = quantityOfThinnerLiters * priceThinnerPerLiter;

            double totalPriceForMaterials = nylonAmount + paintAmount + thinnerAmount + priceForBags;

            double pricePerHour = totalPriceForMaterials * 0.30;
            double totalWorkPrice = pricePerHour * hoursToDoTheWork;

            double totalPrice = totalPriceForMaterials + totalWorkPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
