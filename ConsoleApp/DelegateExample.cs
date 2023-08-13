namespace ConsoleProgramExample
{
    /// <summary>
    /// Delegate is a variable that holds the reference to a method  or pointer to a method
    /// Use: When we need to pass method as a parameter
    /// </summary>

    delegate int Calculator(int x); // declaring delegate
    
    delegate void AnonymousDel(int x, int y);
   
    internal class DelegateExample
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
        public static int multiply(int x)
        {
            return value *= x;
        }
        public static int getvalue()
        {
            return value;
        }

        static void Main(string[] args)
        {
            /*
            // instantiation
            Calculator calc1 = new Calculator(addition);            
            Calculator calc2 = new Calculator(subtract);

            // calling method using delegate
            calc1(30); 
            Console.WriteLine("After calc1 delegate, value is: " + getvalue());
            
            calc2(10);
            Console.WriteLine("After calc2 delegate, value is: " + getvalue());
            */

            /*
            //Multicast Delegate : holds the reference of more than one function
            Calculator calc = new Calculator(addition);
            calc += multiply;
            calc += subtract;

            calc(5);

            Console.WriteLine("After calc multicast delegate, value is: " + getvalue());
            */


            // Anonymous Delegate example : pointing a method which has no name, only body is inline.
            AnonymousDel dl = delegate(int a, int b) 
            {
                //Inline content of the method
                Console.WriteLine("Anonymous delegate ans: {0}", a * b);
            };
            dl(5, 10);
        }
    }
}
