using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CactusTestConsoleApp
{
    internal class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static void Main()
        {
            

            while (true)
            {
                Console.Write("Enter a string or number to check: ");
                string input = Console.ReadLine();

               
                if (input == null || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                bool result = IsPalindrome(input.Trim());
                Console.WriteLine($"'{input}' is a palindrome: {result}");
               
            }
        }
    }
}
