
using System;
using System.Collections.Generic;

// Summary:
// Demonstrates BFS and DFS graph traversal using C# collections.
class Program
{
    static void Main()
    {
        // Create the graph using a Dictionary.
        // Each key represents a node.
        // Each List contains the neighboring nodes.
        Dictionary<string, List<string>> graph =
            new Dictionary<string, List<string>>
            {
                { "A", new List<string> { "B", "C" } },
                { "B", new List<string> { "D" } },
                { "C", new List<string> { "D" } },
                { "D", new List<string> { "E" } },
                { "E", new List<string>() }
            };

        // Create an object of GraphTraversal.
        GraphTraversal traversal = new GraphTraversal();

        // Perform BFS starting from node A.
        List<string> bfsResult =
            traversal.BreadthFirstSearch(graph, "A");

        // Perform DFS starting from node A.
        List<string> dfsResult =
            traversal.DepthFirstSearch(graph, "A");

        // Print the BFS traversal.
        Console.WriteLine("BFS Traversal:");
        Console.WriteLine(string.Join(" -> ", bfsResult));

        // Print the DFS traversal.
        Console.WriteLine();

        Console.WriteLine("DFS Traversal:");
        Console.WriteLine(string.Join(" -> ", dfsResult));

        // BFS uses a Queue, so it processes nodes level by level.
        // DFS uses a Stack, so it goes deeper before visiting other branches.
        // Therefore, their traversal orders can be different.
    }
}
