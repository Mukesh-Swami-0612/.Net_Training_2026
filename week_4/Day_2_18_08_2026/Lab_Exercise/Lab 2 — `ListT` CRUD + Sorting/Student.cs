namespace Lab2StudentRoster;

public class Student
{
    // Stores the unique ID of the student.
    public int Id { get; set; }

    // Stores the student's name.
    public string Name { get; set; }

    // Stores the student's marks.
    public double Marks { get; set; }

    // Creates a Student object with the given values.
    public Student(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    // Returns student information in a readable format.
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Marks: {Marks}";
    }
}