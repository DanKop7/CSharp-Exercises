using System;

class Program
{
    static void Main()
    {
        double speed = double.Parse(Console.ReadLine());

        if (speed <= 30)
        {
            Console.WriteLine("Slow");
        }
        else
        {
            Console.WriteLine("Fast");
        }
    }
}
