using System;

namespace Containment
{
    class Program
    {
        static int notContains(int[] array)
        {
            int Start = 1;
            int Counter = 0;
            for(int i = Start; ; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[j] == i)
                    {
                        Counter += 1;
                        break;
                    }
                }
                if (Counter == 0)
                    return i;
                else
                    Counter = 0;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 7, 8 };
            Console.WriteLine(notContains(array));
        }
    }
}
