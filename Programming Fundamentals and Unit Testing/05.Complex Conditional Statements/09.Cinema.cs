using System;

class Program
{
    static void Main()
    {
        string typeOfMovie = Console.ReadLine();
        int countOfRows = int.Parse(Console.ReadLine());
        int countOfSeatsPerRow = int.Parse(Console.ReadLine());

        double ticketprice = 0;

        switch (typeOfMovie)
        {
            case "Premiere":
                ticketprice = 12.00;
                break;
            case "Normal":
                ticketprice = 7.50;
                break;
            case "Discount":
                ticketprice = 5.00;
                break;
        }

        double profit = countOfRows * countOfSeatsPerRow * ticketprice;

        Console.WriteLine($"{profit:F2}");
    }
}
