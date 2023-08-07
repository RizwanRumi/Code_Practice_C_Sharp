using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate int Calculator(int x); // declaring delegate
    internal class Program
    {
        static int value = 10;

        public static int addition(int x)
        {
            return value += x;
        }

        public static int subtract(int x) 
        {
            return value -= x;
        }

        public static int getvalue()
        {
            return value;
        }

        public static double SumNumber1(int number1, float number2, double number3)
        {
            return number1 + number2 + number3;
        }

        public static void SumNumber2(int number1, float number2, double number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }

        public static bool CheckTheLength(string name) 
        {
            if (name.Length < 10) return true;
            return false;
        }

        static void Main(string[] args)
        {
            /*
            Calculator calc1 = new Calculator(addition); // instantiation            
            Calculator calc2 = new Calculator(subtract);

            calc1(30); // calling method using delegate
            Console.WriteLine("After calc1 delegate, value is: " + getvalue());
            
            calc2(10);
            Console.WriteLine("After calc2 delegate, value is: " + getvalue());
            */

            /*
            DelegateExp single = new DelegateExp();

            singledelegate d1 = new singledelegate(single.addition);
            d1(100, 200);

            singledelegate d2 = new singledelegate(single.subtraction);
            d2(100, 200);
            */

            /*
            DelegateExp multi = new DelegateExp();

            multidelegate md1 = new multidelegate(multi.addition);
            multidelegate md2 = new multidelegate(multi.subtraction);

            multidelegate md3 = md1 + md2;
            md3(100, 200);
            */

            Func<int, float, double, double> object1 = new Func<int, float, double, double>(SumNumber1);
            double output = object1.Invoke(10, 12.15f, 45.38);
            Console.WriteLine(output);

            Action<int, float, double> object2 = new Action<int, float, double>(SumNumber2);
            object2.Invoke(20, 25.25f, 12.45);

            Predicate<string> object3 = new Predicate<string>(CheckTheLength);
            bool b = object3.Invoke("hello");
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
