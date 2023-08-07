using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    //public delegate void singledelegate(int a,  int b);
    public delegate void multidelegate(int a,  int b);
    internal class DelegateExp
    {
        public void addition(int a, int b)
        {
            Console.WriteLine("The Sum is " + (a+b));
        }
        public void subtraction(int a, int b)
        {
            Console.WriteLine("The Difference is " + (a - b));
        }
    }
}
