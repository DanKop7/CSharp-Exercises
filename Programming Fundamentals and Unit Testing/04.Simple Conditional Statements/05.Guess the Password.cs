using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        if (password == "s3cr3t!")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
