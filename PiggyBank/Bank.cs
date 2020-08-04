using System;
using System.Collections.Generic;
using System.Text;

namespace PiggyBank
{
    public class Bank
    {   //Creating random number and declaring coin array
        Random randomNumber;
        static string[] coins = { "penny", "nickel", "dime", "quarter" };

        //Default Constructor
        public Bank()
        {
            randomNumber = new Random();
        }

        //Single parameter argument
        public Bank(int seed)
        {
            randomNumber = new Random(seed);
        }

        
        public int CountmyCoins()
        {
            return randomNumber.Next(10, 50);
        }

        //Returns type of coin based off count
        public string[] GetCoins(int howMany)
        {
            string[] myCoins = new string[howMany];

            for(int i = 0; i < myCoins.Length; i++)
            {
                myCoins[i] = coins[randomNumber.Next(0, 4)];
                Console.Write(myCoins[i] + ", ");
            }
            return myCoins;
        }

        //Calculating the monitary value of all the coins
        public int HowMuch(string[] AlltheCoins)
        {
            int total = 0;

            for(int i = 0; i < AlltheCoins.Length; i++)
            {
                if (AlltheCoins[i] == "penny") total++;
                else if (AlltheCoins[i] == "nickel") total += 5;
                else if (AlltheCoins[i] == "dime") total += 10;
                else if (AlltheCoins[i] == "quarter") total += 25;
            }
            return total;
        }
    }
}
