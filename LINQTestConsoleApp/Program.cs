using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        // List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John"};
        
        var students = new List<Student>() 
        {
            new Student() { Id = 1, Name = "Kim" },
            new Student() { Id = 2, Name = "John" },
        };

        var comparer = new StudentEqualityComparer();

        var isExist = students.Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

        Console.WriteLine("Hello, World!");


        var studentList = new HashSet<Student>(new StudentEqualityComparer())
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" },
            new Student { Id = 1, Name = "Alice" } // Duplicate
        };

        foreach (var student in studentList)
        {
            Console.WriteLine(student.Name);
        }

    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}


class StudentEqualityComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        if (ReferenceEquals(x, y)) return true;

        if (x is null || y is null) return false;

        return x.Id == y.Id && x.Name == y.Name;
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        if(obj == null) return 0;

        int hashId = obj.Id.GetHashCode();
        int hashName = obj.Name == null ? 0 : obj.Name.GetHashCode();

        return hashId ^ hashName;

    }
}