using System;

namespace Parentheses
{
    class Program
    {
        static bool isProperly(string sequence)
        {
            int OpenedCount = 0;
            int ClosedCount = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                    OpenedCount += 1;
                if (sequence[i] == ')')
                    ClosedCount += 1;
                //closed-ma ar unda gadaacharbos open-s
                if (OpenedCount < ClosedCount)
                    return false;
            }
            //dasasruls tolebi unda iyvnen
            if (OpenedCount == ClosedCount)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isProperly("(2+3) * (6 - 7)"));
        }
    }
}
