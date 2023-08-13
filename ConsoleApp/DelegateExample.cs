﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramExample
{
    /// <summary>
    /// Delegate is a variable that holds the reference to a method  or pointer to a method
    /// Use: When we need to pass a method as a parameter
    /// </summary>
    
    delegate int Calculator(int x); // declaring delegate
    
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
        public static int getvalue()
        {
            return value;
        }

        static void Main(string[] args)
        {
            // instantiation
            Calculator calc1 = new Calculator(addition);            
            Calculator calc2 = new Calculator(subtract);

            // calling method using delegate
            calc1(30); 
            Console.WriteLine("After calc1 delegate, value is: " + getvalue());
            
            calc2(10);
            Console.WriteLine("After calc2 delegate, value is: " + getvalue());
            
        }
    }
}
