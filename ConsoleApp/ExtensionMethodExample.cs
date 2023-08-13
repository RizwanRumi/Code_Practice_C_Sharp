using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramExample
{
    internal class ExtensionMethodExample
    {
        private static void Main(string[] args)
        {
            string test = "HelloRumi!";
            string left = test.Substring(0, 5);
            string right = test.RightSubstring(5);

            Console.WriteLine(left + "  " + right);
        }
    }

    public static class StringExtensions
    {
        public static string RightSubstring(this String s, int count)
        {
            return s.Substring(s.Length - count, count);
        }
    } 
}
