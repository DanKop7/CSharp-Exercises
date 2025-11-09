using System;

class Program
{
    static void Main()
    {
        int annualBasketballFee = int.Parse(Console.ReadLine());

        double basketballSneakers = annualBasketballFee - (annualBasketballFee * 0.40);
        double basketballUniform = basketballSneakers - (basketballSneakers * 0.20);
        double basketballBall = basketballUniform / 4;
        double basketballAccessories = basketballBall / 5;

        double totalPrice = annualBasketballFee + basketballSneakers + basketballUniform + basketballBall + basketballAccessories;

        Console.WriteLine(totalPrice);
    }
}
