using System;

namespace PalindromeNumbers
{
    class Program : PalindromeNumber
    {
        public static void Main(string[] args)
        {
            //-121
            //10
            //12321
            int TestNum = 12321;
            Console.WriteLine($"{IsPalindrome(TestNum)}");
        }
    }
}
