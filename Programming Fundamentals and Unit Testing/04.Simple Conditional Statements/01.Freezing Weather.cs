using System;

class Program
{
    static void Main()
    {
        int temperatureInCelsius = int.Parse(Console.ReadLine());

        if (temperatureInCelsius >= 0)
        {
            Console.WriteLine("Above freezing.");
        }
        else 
        {
            Console.WriteLine("Freezing weather!");
        }
    }
}
