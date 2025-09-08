using System;

class Program
{
    static void Main()
    {
        double bathroomW = double.Parse(Console.ReadLine());
        double bathroomH = double.Parse(Console.ReadLine());
        double tileW = double.Parse(Console.ReadLine());
        double tileH = double.Parse(Console.ReadLine());

        double bathArea = bathroomW * bathroomH;
        bathArea = bathArea + 0.10 * bathArea;
        double tileArea = tileW * tileH;
        double totalTiles = bathArea / tileArea;

        Console.WriteLine(Math.Round(totalTiles));
    }
}
