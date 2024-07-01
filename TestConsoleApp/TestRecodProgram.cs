using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TestRecodProgram
{
    public record Person(string FirstName, string LastName);
    public record Employee(string FirstName, string LastName, string JobTitle) : Person(FirstName, LastName);
    private static void Main(string[] args)
    {
        Console.WriteLine("This is from Test Program class");

        var person1 = new Person("Rizwan", "Rumi"); 
        var person2 = new Person("Tanvir", "Ahmed");
        var person3 = new Person("Tanvir", "Ahmed");

        // value equality
        Console.WriteLine(person1 == person2); // output: False
        Console.WriteLine(person2 == person3); // output: True
        Console.WriteLine(Person.ReferenceEquals(person2, person3)); // output: False (same instance are considered equal, different from class) 
        Console.WriteLine(Person.Equals(person2, person3)); // output: True
        Console.WriteLine(person2.Equals(person3)); // output: True

        //Immutable by default
        // person1.FirstName = "Rahman"; // cause a compile error

        // Deconstruction
        var (firstName, lastName) = person1;
        Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}"); // Output: First Name: Rizwan, Last Name: Rumi

        // Record inheritance
        var employee = new Employee("Jane", "Doe", "Developer");
        Console.WriteLine(employee); // Output: Employee { FirstName = Jane, LastName = Doe, JobTitle = Developer }
    }
}