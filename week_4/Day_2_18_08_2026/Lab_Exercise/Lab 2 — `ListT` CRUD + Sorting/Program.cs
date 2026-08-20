namespace Lab2StudentRoster;

public class Program
{
    public static void Main()
    {
        StudentRoster roster = new();

        Console.WriteLine("STUDENT ROSTER MANAGER");

        // 1. ADD STUDENTS

        Console.WriteLine("\n--- Adding Students ---");

        roster.AddStudent(new Student(1, "Rahul", 82.5));
        roster.AddStudent(new Student(2, "Amit", 91.0));
        roster.AddStudent(new Student(3, "Priya", 88.5));
        roster.AddStudent(new Student(4, "Neha", 76.0));
        roster.AddStudent(new Student(5, "Vikas", 95.0));

        PrintRoster(roster.GetStudents());

        // 2. UPDATE MARKS

        Console.WriteLine("\n--- Updating Marks ---");

        Console.WriteLine("Before update:");
        PrintRoster(roster.GetStudents());

        bool updated = roster.UpdateMarks(4, 89.0);

        Console.WriteLine(
            updated
                ? "\nStudent ID 4 marks updated successfully."
                : "\nStudent ID 4 not found.");

        Console.WriteLine("\nAfter update:");
        PrintRoster(roster.GetStudents());


        // 3. REMOVE STUDENT

        Console.WriteLine("\n--- Removing Student ---");

        Console.WriteLine("Before removal:");
        PrintRoster(roster.GetStudents());

        bool removed = roster.RemoveStudent(2);

        Console.WriteLine(
            removed
                ? "\nStudent ID 2 removed successfully."
                : "\nStudent ID 2 not found.");

        Console.WriteLine("\nAfter removal:");
        PrintRoster(roster.GetStudents());


        // 4. GET TOP STUDENT

        Console.WriteLine("\n--- Top Student ---");

        Student? topStudent = roster.GetTopStudent();

        if (topStudent != null)
        {
            Console.WriteLine($"Top Student: {topStudent}");
        }


        // 5. SORT BY MARKS USING LAMBDA

        Console.WriteLine("\n--- Sorting By Marks (Descending) ---");

        List<Student> studentsByMarks = roster.GetStudents();

        studentsByMarks.Sort(
            (student1, student2) =>
                student2.Marks.CompareTo(student1.Marks));

        PrintRoster(studentsByMarks);


        // 6. SORT BY NAME USING ICOMPARER

        Console.WriteLine("\n--- Sorting By Name (Ascending) ---");

        studentsByMarks.Sort(new ByNameComparer());

        PrintRoster(studentsByMarks);

    }

    // Prints all students currently present in the list.
    private static void PrintRoster(List<Student> students)
    {
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}