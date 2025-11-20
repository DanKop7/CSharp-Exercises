using System;

class Program
{
    static void Main()
    {
        int numberAsWords = int.Parse(Console.ReadLine());

        if (numberAsWords == 1)
        {
            Console.WriteLine("one");
        }
        else if (numberAsWords == 2)
        {
            Console.WriteLine("two");
        }
        else if (numberAsWords == 3)
        {
            Console.WriteLine("three");
        }
        else if (numberAsWords == 4)
        {
            Console.WriteLine("four");
        }
        else if (numberAsWords == 5)
        {
            Console.WriteLine("five");
        }
        else if (numberAsWords == 6)
        {
            Console.WriteLine("six");
        }
        else if (numberAsWords == 7)
        {
            Console.WriteLine("seven");
        }
        else if (numberAsWords == 8)
        {
            Console.WriteLine("eight");
        }
        else if (numberAsWords == 9)
        {
            Console.WriteLine("nine");
        }
        else
        {
            Console.WriteLine("Out of range");
        }
    }
}
