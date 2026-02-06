using System;

class Program
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo && numberOne > numberThree)
        {
            Console.WriteLine(numberOne);
        }
        else if (numberTwo > numberOne && numberTwo > numberThree)
        {
            Console.WriteLine(numberTwo);
        }
        else if (numberThree > numberOne && numberThree > numberTwo)
        {
            Console.WriteLine(numberThree);
        }
    }
}
