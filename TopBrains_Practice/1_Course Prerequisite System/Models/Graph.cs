using System;
using System.Collections.Generic;

namespace CoursePrerequisiteSystem.Models
{
    /// <summary>
    /// Represents a Directed Graph using an Adjacency List.
    ///
    /// In this project:
    /// - Each vertex represents a course.
    /// - Each directed edge represents a prerequisite relationship.
    ///
    /// Example:
    ///     0 → 1
    ///
    /// Means:
    /// Course 0 must be completed before Course 1.
    ///
    /// This class acts as the foundation of the entire project because
    /// all graph algorithms (DFS, Cycle Detection, Topological Sort)
    /// operate on this graph structure.
    /// </summary>
    public class Graph
    {
        //------------------------------------------------------------------
        // Private Data Members
        //------------------------------------------------------------------

        /// <summary>
        /// Stores the graph using an adjacency list.
        ///
        /// Each index represents one course (vertex).
        ///
        /// The list at each index contains all courses that directly
        /// depend on that course.
        ///
        /// Example:
        ///
        /// adjacencyList[2] = {3,4}
        ///
        /// Represents:
        ///
        /// 2 → 3
        /// 2 → 4
        ///
        /// Using an adjacency list is memory efficient for sparse graphs
        /// because it stores only existing edges.
        /// </summary>
        private readonly List<int>[] adjacencyList;

        //------------------------------------------------------------------
        // Public Properties
        //------------------------------------------------------------------

        /// <summary>
        /// Gets the total number of vertices (courses) in the graph.
        ///
        /// Example:
        /// Vertices = 6
        ///
        /// Course Numbers:
        /// 0
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// </summary>
        public int Vertices { get; }

        //------------------------------------------------------------------
        // Constructor
        //------------------------------------------------------------------

        /// <summary>
        /// Creates a new directed graph.
        ///
        /// The constructor allocates memory for the adjacency list
        /// and initializes an empty list for every course.
        ///
        /// Initially no prerequisite relationships exist.
        /// </summary>
        /// <param name="vertices">
        /// Total number of vertices (courses) in the graph.
        /// </param>
        public Graph(int vertices)
        {
            // Store the total number of vertices.
            // This value can later be used by traversal algorithms.
            Vertices = vertices;

            // Create an array of lists.
            //
            // Example (before initialization):
            //
            // Index
            // 0 -> null
            // 1 -> null
            // 2 -> null
            // 3 -> null
            // 4 -> null
            // 5 -> null
            adjacencyList = new List<int>[vertices];

            // Initialize every list in the array.
            //
            // After initialization:
            //
            // 0 -> []
            // 1 -> []
            // 2 -> []
            // 3 -> []
            // 4 -> []
            // 5 -> []
            //
            // Each empty list is ready to store outgoing edges.
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        //------------------------------------------------------------------
        // AddEdge()
        //------------------------------------------------------------------

        /// <summary>
        /// Adds a directed edge between two vertices.
        ///
        /// The edge represents a prerequisite relationship.
        ///
        /// Format:
        ///
        /// prerequisite → course
        ///
        /// Example:
        ///
        /// AddEdge(2,4)
        ///
        /// Creates:
        ///
        /// 2 → 4
        ///
        /// Meaning:
        /// Course 4 requires Course 2.
        /// </summary>
        /// <param name="prerequisite">
        /// The prerequisite course.
        /// </param>
        ///
        /// <param name="course">
        /// The course that depends on the prerequisite.
        /// </param>
        public void AddEdge(int prerequisite, int course)
        {
            // Insert the dependent course into the adjacency list
            // of the prerequisite course.
            //
            // Example:
            //
            // Before:
            // adjacencyList[2] = []
            //
            // After AddEdge(2,4):
            //
            // adjacencyList[2] = [4]
            adjacencyList[prerequisite].Add(course);
        }

        //------------------------------------------------------------------
        // GetNeighbours()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns all neighbouring vertices directly connected
        /// to the specified vertex.
        ///
        /// Example:
        ///
        /// Graph:
        ///
        /// 2 → 3
        /// 2 → 4
        ///
        /// Calling:
        ///
        /// GetNeighbours(2)
        ///
        /// Returns:
        ///
        /// {3,4}
        /// </summary>
        /// <param name="vertex">
        /// The source vertex.
        /// </param>
        ///
        /// <returns>
        /// A list containing all neighbouring vertices.
        /// </returns>
        public List<int> GetNeighbours(int vertex)
        {
            // Return all directly connected neighbours.
            return adjacencyList[vertex];
        }

        //------------------------------------------------------------------
        // GetAdjacencyList()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns the complete adjacency list of the graph.
        ///
        /// This method is mainly used by graph algorithms such as:
        ///
        /// • DFS Traversal
        /// • Cycle Detection
        /// • Topological Sorting
        ///
        /// Returning the adjacency list allows these algorithms
        /// to inspect every vertex and every edge efficiently.
        /// </summary>
        ///
        /// <returns>
        /// Complete adjacency list representing the graph.
        /// </returns>
        public List<int>[] GetAdjacencyList()
        {
            // Return the entire graph structure.
            return adjacencyList;
        }
    }
}