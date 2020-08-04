using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piggy Bank Excercise");

            //Passing a single argument to the constructor 
            Bank MyBank = new Bank(73);

            //Printing Number of coins in the bank
            int numCoins = MyBank.CountmyCoins();
            Console.WriteLine($"There are {numCoins} coins in the bank.");

            //Printing coins in the bank
            Console.WriteLine($"\nThe coins in the bank are:\n");
            string[] allMyCoins = MyBank.GetCoins(numCoins);

            //Printing out total 
            Console.WriteLine($"\n\n There are {MyBank.HowMuch(allMyCoins)} cents in the bank.");

        }
    }
}
