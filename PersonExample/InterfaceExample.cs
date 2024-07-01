using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    // Interface to define a protocol of behavior or a design guideline that can be implemented by any class anywhere in the class hierarchy
    internal class InterfaceExample
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Interface Example Using Person");

            IPerson student = new Student("Rizwan", 20, "TU Chemnitz");
            student.DisplayInfo(); 
           
            IPerson teacher = new Teacher("Rumi", 35, "Computer Science");
            teacher.DisplayInfo(); 
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void DisplayInfo();
    }

    // Class Student implementing IPerson
    public class Student : IPerson
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string School { get; set; }

        // Constructor
        public Student(string name, int age, string school)
        {
            Name = name;
            Age = age;
            School = school;
        }

        // Implementing method from interface
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
        }
    }

    // Class Teacher implementing IPerson
    public class Teacher : IPerson
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }

        // Constructor
        public Teacher(string name, int age, string subject)
        {
            Name = name;
            Age = age;
            Subject = subject;
        }

        // Implementing method from interface
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
