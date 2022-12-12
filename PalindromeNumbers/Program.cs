using System;
/*
 * @author Billy Bedon Pacheco
 */

namespace PalindromeNumbers
{
    class Program : PalindromeNumber
    {
        public static void Main(string[] args)
        {
            //-121
            //10
            //12321
            int TestNum = 121;
            Console.WriteLine($"{IsPalindrome(TestNum)}");
        }
    }
}
