using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if ((number >= 100 && number <= 200) || number == 0)
        {
            // Valid number, no output required
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}
