using System;

class Program
{
    static void Main()
    {
        int balance = int.Parse(Console.ReadLine());
        int withdraw = int.Parse(Console.ReadLine());
        int limit = int.Parse(Console.ReadLine());

        if (balance >= withdraw && limit >= withdraw)
        {
            Console.WriteLine("The withdraw was successful.");
        }
        else if (withdraw > limit)
        {
            Console.WriteLine("The limit was exceeded.");
        }
        else if (withdraw > balance)
        {
            Console.WriteLine("Insufficient availability.");
        }
    }
}
