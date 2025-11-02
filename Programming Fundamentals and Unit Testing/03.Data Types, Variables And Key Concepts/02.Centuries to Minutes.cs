using System;

class Program
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        int centuriesToYears = centuries * 100;
        int yearsToDays = (int)(centuriesToYears * 365.2422);
        int daysToHours = yearsToDays * 24;
        int hoursToMinutes = daysToHours * 60;

        Console.WriteLine($"{centuries} centuries = {centuriesToYears} years = {yearsToDays} days = {daysToHours} hours = {hoursToMinutes} minutes");
    }
}
