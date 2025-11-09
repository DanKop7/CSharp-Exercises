using System;

class Program
{
    static void Main()
    {
        int lengthInCm = int.Parse(Console.ReadLine());
        int widthInCm = int.Parse(Console.ReadLine());
        int heightInCm = int.Parse(Console.ReadLine());
        double percentage = int.Parse(Console.ReadLine());

        double aquariumVolume = lengthInCm * widthInCm * heightInCm;
        double litterVolume = aquariumVolume / 1000;

        double requiredLitters = litterVolume * (1 - percentage / 100);

        Console.WriteLine($"{requiredLitters:F2}");
    }
}
