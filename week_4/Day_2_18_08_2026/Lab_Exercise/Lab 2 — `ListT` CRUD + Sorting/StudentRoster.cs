namespace Lab2StudentRoster;

public class StudentRoster
{
    // Stores all students in a generic List<Student>.
    private readonly List<Student> students = new();

    // Adds a student to the roster.
    public void AddStudent(Student s)
    {
        students.Add(s);
    }

    // Removes a student using their ID.
    public bool RemoveStudent(int id)
    {
        Student? student = students.Find(s => s.Id == id);

        if (student == null)
        {
            return false;
        }

        students.Remove(student);
        return true;
    }

    // Updates the marks of a student using their ID.
    public bool UpdateMarks(int id, double newMarks)
    {
        Student? student = students.Find(s => s.Id == id);

        if (student == null)
        {
            return false;
        }

        student.Marks = newMarks;
        return true;
    }

    // Returns the student with the highest marks.
    public Student? GetTopStudent()
    {
        if (students.Count == 0)
        {
            return null;
        }

        return students.MaxBy(s => s.Marks);
    }

    // Returns the internal list so Program.cs can demonstrate sorting.
    public List<Student> GetStudents()
    {
        return students;
    }
}