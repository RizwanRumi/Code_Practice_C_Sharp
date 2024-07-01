using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    // Abstract classes when you want to define a common base with some default behavior
    internal class AbstractClassExample
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class Example Using Person");            

            Student student = new Student("Rizwan", 33, "TU Chemnitz");
            student.DisplayInfo();

            Teacher teacher = new Teacher("Rumi", 55, "Automotive Engineering");
            teacher.DisplayInfo();
        }
    }

    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void DisplayInfo();
    }

    // Concrete class Student inheriting from Person
    public class Student : Person
    {
        // Concrete properties
        public override string Name { get; set; }
        public override int Age { get; set; }
        public string School { get; set; }

        // Constructor
        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        // Implementing abstract method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
        }
    }

    // Concrete class Teacher inheriting from Person
    public class Teacher : Person
    {
        // Concrete properties
        public override string Name { get; set; }
        public override int Age { get; set; }
        public string Subject { get; set; }

        // Constructor
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        // Implementing abstract method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
