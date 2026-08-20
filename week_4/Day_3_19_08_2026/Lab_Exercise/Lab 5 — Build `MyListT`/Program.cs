using System;

// Custom reference type used to test MyList<T>.
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Controls how Student objects are displayed.
    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}

// Program demonstrates the MyList<T> functionality.
class Program
{
    // Main method runs all MyList<T> demonstrations.
    static void Main()
    {
        // ---------------------------------------------------------
        // 1. Test MyList<T> with int
        // ---------------------------------------------------------

        Console.WriteLine("===== MyList<int> =====");

        // Collection-initializer syntax.
        // Internally, this calls Add(1), Add(2), and Add(3).
        MyList<int> numbers = new MyList<int>
        {
            1,
            2,
            3
        };

        Console.WriteLine($"Count: {numbers.Count}");

        // ---------------------------------------------------------
        // 2. Prove indexer get works
        // ---------------------------------------------------------

        Console.WriteLine($"First element: {numbers[0]}");

        // ---------------------------------------------------------
        // 3. Prove indexer set works
        // ---------------------------------------------------------

        numbers[1] = 20;

        Console.WriteLine($"After changing index 1: {numbers[1]}");

        // ---------------------------------------------------------
        // 4. Add more elements
        // ---------------------------------------------------------

        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);

        Console.WriteLine($"Count after adding: {numbers.Count}");

        // ---------------------------------------------------------
        // 5. Prove foreach works
        // ---------------------------------------------------------

        Console.WriteLine("Elements using foreach:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // ---------------------------------------------------------
        // 6. Remove an element
        // ---------------------------------------------------------

        numbers.RemoveAt(2);

        Console.WriteLine("After RemoveAt(2):");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Count after removal: {numbers.Count}");

        // ---------------------------------------------------------
        // 7. Test MyList<T> with a custom reference type
        // ---------------------------------------------------------

        Console.WriteLine();
        Console.WriteLine("===== MyList<Student> =====");

        MyList<Student> students = new MyList<Student>();

        students.Add(new Student("Rahul", 21));
        students.Add(new Student("Priya", 22));
        students.Add(new Student("Amit", 20));

        // foreach works with custom reference types as well.
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // ---------------------------------------------------------
        // 8. Deliberately trigger an out-of-range access
        // ---------------------------------------------------------

        Console.WriteLine();
        Console.WriteLine("===== Out-of-Range Test =====");

        try
        {
            // Valid indexes are 0 through Count - 1.
            // This access deliberately uses an invalid index.
            Console.WriteLine(numbers[100]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception caught successfully.");
            Console.WriteLine($"Message: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Program completed.");
    }
}