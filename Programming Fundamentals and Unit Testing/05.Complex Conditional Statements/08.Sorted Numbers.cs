using System;

class Program
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());  
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());

        if (numberOne < numberTwo && numberOne < numberThree && numberTwo < numberThree)
        {
            Console.WriteLine("Ascending");
        }
        else if (numberOne > numberTwo && numberOne > numberThree && numberTwo > numberThree)
        {
            Console.WriteLine("Descending");
        }
        else
        {
            Console.WriteLine("Not sorted");
        }
    }
}
