using System;

namespace Splitting
{
    class Program
    {
        //dinamiuri daprogramebis amocana
        static int minSplit(int amount)
        {
            //1 5 10 20 50
            int NumberOfCoins = 0;
            if(amount >= 50)
            {
                NumberOfCoins += amount / 50;
                amount = amount % 50;
            }
            if (amount >= 20)
            {
                NumberOfCoins += amount / 20;
                amount = amount % 20;
            }
            if(amount >= 10)
            {
                NumberOfCoins += amount / 10;
                amount = amount % 10;
            }
            if (amount >= 5)
            {
                NumberOfCoins += amount / 5;
                amount = amount % 5;
            }
            if (amount >= 1)
            {
                NumberOfCoins += amount;
            }
            if(amount < 0)
            {
                return -1;
            }
            return NumberOfCoins;

        }
        static void Main(string[] args)
        {
            int Test = minSplit(123);
            if (Test != -1)
            {
                Console.WriteLine(Test);
            }
            else
            {
                Console.WriteLine("Something Went Wrong!");
            }
        }
    }
}
