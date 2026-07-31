// Program.cs

using System;

class Program
{
    /// <summary>
    /// Entry point of the application.
    /// Creates vertices and an edge, then
    /// displays their details.
    /// </summary>
    static void Main(string[] args)
    {
        // Create the first vertex.
        Vertex vertex1 = new Vertex(1, "A");

        // Create the second vertex.
        Vertex vertex2 = new Vertex(2, "B");

        // Create an edge from Vertex 1 to Vertex 2 with weight 10.
        Edge edge = new Edge(vertex2.Id, 10);

        // Display the details of the first vertex.
        Console.WriteLine("Vertex 1");
        Console.WriteLine("Id : " + vertex1.Id);
        Console.WriteLine("Label : " + vertex1.Label);

        // Print a blank line for better output formatting.
        Console.WriteLine();

        // Display the details of the second vertex.
        Console.WriteLine("Vertex 2");
        Console.WriteLine("Id : " + vertex2.Id);
        Console.WriteLine("Label : " + vertex2.Label);

        // Print a blank line for better output formatting.
        Console.WriteLine();

        // Display the edge information.
        Console.WriteLine("Edge Details");
        Console.WriteLine("Destination : " + edge.Destination);
        Console.WriteLine("Weight : " + edge.Weight);
    }
}