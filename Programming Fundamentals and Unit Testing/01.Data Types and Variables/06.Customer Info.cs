using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string email = Console.ReadLine();

        Console.WriteLine($"Customer: {firstName} {lastName} ({email})");
    }
}
