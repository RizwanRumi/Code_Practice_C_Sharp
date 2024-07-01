internal class ClassExample
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Class Example Using Person");

        Person person = new Person("Unknown", 47);
        person.DisplayInfo();

        Student student = new Student("Rizwan", 33, "TU Chemnitz");
        student.DisplayInfo();

        Teacher teacher = new Teacher("Rumi", 55, "MatheMatics");
        teacher.DisplayInfo();
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public string School { get; set; }
    public Student(string name, int age, string school) : base(name, age)
    {
        this.Name = name;
        this.Age = age;
        this.School = school;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        this.Name = name;
        this.Age = age;
        this.Subject = subject;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
