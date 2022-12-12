/*
 * @author Billy Bedon Pacheco
 */
namespace PalindromeNumbers
{
    internal class PalindromeNumber
    {
        public static bool IsPalindrome(int number)
        {
            if (number < 0) return false; //We validate the number we are going to check if its lower than 0

            int reversedNum = 0;     //Will hold the Reversed Number to compare with tempNum 
            int tempNum = number;   //Will hold the Number to compare with the reversedNum
            int leftoverNum;

            while (tempNum > 0)
            {
                leftoverNum = tempNum % 10; //Holds remaining number from a division
                tempNum = tempNum / 10;  //We divide it by 10 to change the original Number and let the loop continue
                reversedNum = reversedNum * 10 + leftoverNum;   //We multiply reversedNum by 10 and then add the leftover number
            }

            return number == reversedNum;    //returns True if the number is Palindrome, False if not.
        }
    }
}