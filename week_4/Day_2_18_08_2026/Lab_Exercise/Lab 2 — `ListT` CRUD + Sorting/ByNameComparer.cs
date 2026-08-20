namespace Lab2StudentRoster;

public class ByNameComparer : IComparer<Student>
{
    // Compares two students based on their names.
    public int Compare(Student? x, Student? y)
    {
        if (ReferenceEquals(x, y))
        {
            return 0;
        }

        if (x is null)
        {
            return -1;
        }

        if (y is null)
        {
            return 1;
        }

        return string.Compare(
            x.Name,
            y.Name,
            StringComparison.OrdinalIgnoreCase);
    }
}