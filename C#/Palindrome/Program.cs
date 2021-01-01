using System;

namespace Palindrome
{
    class Program
    {
        static bool isPalindrome(string Text)
        {

            Text = Text.ToUpper();
            int End = Text.Length - 1;
            int Start = 0;

            for( int i = Start , j = End ; i < Text.Length/2; i++, j--)
                if (Text[i] != Text[j])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            bool Test = isPalindrome("GUGGGUG");
            Console.WriteLine(Test);
        }
    }
}
