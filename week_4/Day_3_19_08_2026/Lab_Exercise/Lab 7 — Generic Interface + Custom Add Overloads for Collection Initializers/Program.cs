using System;

namespace Lab7;

public class Program
{
    public static void Main()
    {
        // --------------------------------------------------
        // PART 1: Generic Repository
        // --------------------------------------------------

        // Creates a repository that stores Student objects.
        IRepository<Student> repository = new InMemoryRepository<Student>();

        // Creates student objects.
        var student1 = new Student(1, "Mukesh", "CSE");
        var student2 = new Student(2, "Rahul", "IT");
        var student3 = new Student(3, "Aman", "ECE");

        // Adds students to the repository.
        repository.Add(student1);
        repository.Add(student2);
        repository.Add(student3);

        Console.WriteLine("=== Generic Repository ===");

        // Retrieves a student using its ID.
        var student = repository.GetById(2);

        if (student != null)
        {
            Console.WriteLine("Student found:");
            Console.WriteLine(student);
        }

        Console.WriteLine();

        // Gets and displays all students.
        Console.WriteLine("All students:");

        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // --------------------------------------------------
        // PART 2: TagList and Collection Initializer
        // --------------------------------------------------

        Console.WriteLine("=== TagList Collection Initializer ===");

        // Uses both Add(string) and Add(string, bool)
        // through collection initializer syntax.
        var tags = new TagList
        {
            "CSharp",
            { "DotNet", true },
            "Programming",
            { "Backend", false },
            { "Generics", true }
        };

        // Prints tag information.
        tags.PrintDetails();

        Console.WriteLine();

        // Demonstrates that TagList supports foreach.
        Console.WriteLine("Tags using foreach:");

        foreach (var tag in tags)
        {
            Console.WriteLine(tag);
        }
    }
}