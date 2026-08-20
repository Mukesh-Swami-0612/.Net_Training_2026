
using System;
using System.Collections.Generic;

// Summary:
// Provides methods for traversing a graph using BFS and DFS.
public class GraphTraversal
{
    // Summary:
    // Performs Breadth-First Search using Queue and HashSet.
    public List<string> BreadthFirstSearch(
        Dictionary<string, List<string>> graph,
        string startNode)
    {
        // Stores nodes waiting to be processed.
        Queue<string> queue = new Queue<string>();

        // Stores nodes that have already been visited.
        HashSet<string> visited = new HashSet<string>();

        // Stores the final traversal order.
        List<string> result = new List<string>();

        // Add the starting node to the queue.
        queue.Enqueue(startNode);

        // Mark the starting node as visited.
        visited.Add(startNode);

        // Continue until there are no nodes left in the queue.
        while (queue.Count > 0)
        {
            // Remove the first node from the queue.
            string currentNode = queue.Dequeue();

            // Add the current node to the result.
            result.Add(currentNode);

            // Check all neighboring nodes.
            foreach (string neighbor in graph[currentNode])
            {
                // Only process nodes that have not been visited.
                if (!visited.Contains(neighbor))
                {
                    // Mark the neighbor as visited.
                    visited.Add(neighbor);

                    // Add the neighbor to the queue.
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }

    // Summary:
    // Performs Depth-First Search using Stack and HashSet.
    public List<string> DepthFirstSearch(
        Dictionary<string, List<string>> graph,
        string startNode)
    {
        // Stores nodes waiting to be processed.
        Stack<string> stack = new Stack<string>();

        // Stores nodes that have already been visited.
        HashSet<string> visited = new HashSet<string>();

        // Stores the final traversal order.
        List<string> result = new List<string>();

        // Add the starting node to the stack.
        stack.Push(startNode);

        // Continue until there are no nodes left in the stack.
        while (stack.Count > 0)
        {
            // Remove the top node from the stack.
            string currentNode = stack.Pop();

            // Skip the node if it was already visited.
            if (visited.Contains(currentNode))
            {
                continue;
            }

            // Mark the node as visited.
            visited.Add(currentNode);

            // Add the node to the result.
            result.Add(currentNode);

            // Push neighboring nodes onto the stack.
            foreach (string neighbor in graph[currentNode])
            {
                // Only push nodes that have not been visited.
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
        }

        return result;
    }
}

