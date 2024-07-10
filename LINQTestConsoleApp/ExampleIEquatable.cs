using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestConsoleApp
{
    internal class ExampleIEquatable
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 3, Name = "Mike"}
            };

            var ms = students.Distinct().ToList();

            foreach(var student in ms)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    class Student : IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Student? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if(ReferenceEquals(this, other)) return true;

            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
