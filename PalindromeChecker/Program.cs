using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string checkString =Console.ReadLine();

            if (isPalindrome(checkString))
            {
                Console.WriteLine("The Input is palindrome.");
            }
            else
            {
                Console.WriteLine("The input is not palindrome");
            }

            Console.ReadKey();

        }

        private static bool isPalindrome(string checkString)
        {
            checkString= checkString.Trim().ToLower();

            for(int i=0; i < checkString.Length/2; i++)
            {
                if (checkString[i] != checkString[checkString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
