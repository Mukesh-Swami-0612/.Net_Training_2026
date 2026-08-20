namespace Lab7;

// Represents a student entity stored in the repository.
public class Student : IEntity
{
    // Gets or sets the student's ID.
    public int Id { get; set; }

    // Gets or sets the student's name.
    public string Name { get; set; }

    // Gets or sets the student's course.
    public string Course { get; set; }

    // Creates a Student object.
    public Student(int id, string name, string course)
    {
        Id = id;
        Name = name;
        Course = course;
    }

    // Returns a readable representation of the student.
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Course: {Course}";
    }
}