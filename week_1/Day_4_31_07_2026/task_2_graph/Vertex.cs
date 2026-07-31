// Vertex.cs

public class Vertex
{
    // Unique identifier of the vertex.
    public int Id { get; set; }

    // Name or label of the vertex.
    public string Label { get; set; }

    // Constructor
    public Vertex(int id, string label = null)
    {
        Id = id;

        // If label is null, use the id as the label.
        Label = label ?? id.ToString();
    }

    // Returns the label when the object is printed.
    public override string ToString() => Label;
}