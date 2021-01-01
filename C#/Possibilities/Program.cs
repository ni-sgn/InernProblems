using System;

namespace Possibilities
{
    class Program
    {
        static int countVariants(int stearsCount)
        {
            int NumberOfOnes = stearsCount;
            int NumberOfTwos = 0;
            int MaxTwos = stearsCount / 2;

            int variants = 0;

            while(NumberOfTwos < MaxTwos)
            {
                NumberOfTwos += 1;
                NumberOfOnes -= 2;

                //chavtvalot ro (2,1) != (1,2)
                int nFactorial = 1;
                for (int i = NumberOfOnes + NumberOfTwos; i > 1; i--)
                {
                    nFactorial *= i;
                }
                
                variants += nFactorial;
            }
            // +1, (1,1,1, ...) chavtvalot 1 variantad
            return variants+1;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(countVariants(5));
        }
    }
}
