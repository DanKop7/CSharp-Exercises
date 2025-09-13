using System;

class Program
{
    static void Main()
    {
        double depositAmount = double.Parse(Console.ReadLine());
        int termDeposit = int.Parse(Console.ReadLine());
        double annualRate = double.Parse(Console.ReadLine()) / 100;

        double amount = depositAmount + termDeposit * (depositAmount * annualRate) / 12;

        Console.WriteLine($"{amount:F2}");
    }
}
