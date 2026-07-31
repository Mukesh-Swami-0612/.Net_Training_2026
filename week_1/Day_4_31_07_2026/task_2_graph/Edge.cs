// Edge.cs

public class Edge
{
    // Stores the destination vertex of the edge.
    public int Destination { get; set; }

    // Stores the weight (cost) of the edge.
    // Default weight is 1.
    public int Weight { get; set; }

    // Constructor
    public Edge(int destination, int weight = 1)
    {
        Destination = destination;
        Weight = weight;
    }
}