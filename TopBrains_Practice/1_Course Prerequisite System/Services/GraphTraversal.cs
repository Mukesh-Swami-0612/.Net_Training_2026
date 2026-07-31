using System.Collections.Generic;
using CoursePrerequisiteSystem.Models;

namespace CoursePrerequisiteSystem.Services
{
    /// <summary>
    /// The GraphTraversal class contains utility methods for
    /// traversing and analyzing the course prerequisite graph.
    ///
    /// Responsibilities:
    /// • Find all prerequisites (direct + indirect)
    /// • Find direct prerequisites
    /// • Find courses with no prerequisites
    /// • Count direct dependents of a course
    ///
    /// This class separates traversal algorithms from the Graph class,
    /// following the Single Responsibility Principle (SRP).
    /// </summary>
    public static class GraphTraversal
    {
        //------------------------------------------------------------------
        // GetAllPrerequisites()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns every prerequisite required for a target course.
        ///
        /// This includes both:
        /// • Direct prerequisites
        /// • Indirect prerequisites
        ///
        /// Example:
        ///
        /// Original Graph
        ///
        /// 0 → 1
        /// 0 → 2
        /// 1 → 3
        /// 2 → 3
        /// 3 → 5
        ///
        /// Calling:
        ///
        /// GetAllPrerequisites(graph,5)
        ///
        /// Returns:
        /// 0,1,2,3
        ///
        /// Algorithm Used:
        /// 1. Reverse the graph.
        /// 2. Run DFS from the target course.
        /// 3. Collect every visited vertex.
        /// </summary>
        ///
        /// <param name="graph">
        /// Original prerequisite graph.
        /// </param>
        ///
        /// <param name="targetCourse">
        /// Course whose prerequisites are required.
        /// </param>
        ///
        /// <returns>
        /// List containing all direct and indirect prerequisites.
        /// </returns>
        public static List<int> GetAllPrerequisites(Graph graph, int targetCourse)
        {
            // Create a reverse graph.
            // This changes:
            //
            // 0 → 1
            //
            // into
            //
            // 1 → 0
            //
            // making prerequisite searching easier.
            Graph reverseGraph = BuildReverseGraph(graph);

            // Keeps track of already visited courses.
            bool[] visited = new bool[graph.Vertices];

            // Stores the final prerequisite list.
            List<int> result = new();

            // Perform DFS traversal from the target course.
            DFS(reverseGraph, targetCourse, visited, result);

            // Return all collected prerequisites.
            return result;
        }

        //------------------------------------------------------------------
        // GetDirectPrerequisites()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns only the immediate prerequisites of a course.
        ///
        /// Example:
        ///
        /// 1 → 3
        /// 2 → 3
        ///
        /// Calling:
        ///
        /// GetDirectPrerequisites(graph,3)
        ///
        /// Returns:
        ///
        /// 1,2
        /// </summary>
        ///
        /// <param name="graph">
        /// Original prerequisite graph.
        /// </param>
        ///
        /// <param name="targetCourse">
        /// Course whose immediate prerequisites are required.
        /// </param>
        ///
        /// <returns>
        /// List containing only direct prerequisites.
        /// </returns>
        public static List<int> GetDirectPrerequisites(Graph graph, int targetCourse)
        {
            // Reverse the graph so incoming edges become outgoing edges.
            Graph reverseGraph = BuildReverseGraph(graph);

            // Return only immediate neighbours
            // from the reversed graph.
            return reverseGraph.GetNeighbours(targetCourse);
        }

        //------------------------------------------------------------------
        // GetCoursesWithoutPrerequisites()
        //------------------------------------------------------------------

        /// <summary>
        /// Finds all courses that have no prerequisites.
        ///
        /// A course with an indegree of zero
        /// can be taken immediately.
        ///
        /// Example:
        ///
        /// 0 → 1
        /// 0 → 2
        ///
        /// Result:
        ///
        /// Course 0
        /// </summary>
        ///
        /// <param name="graph">
        /// Course prerequisite graph.
        /// </param>
        ///
        /// <returns>
        /// List of courses having no prerequisites.
        /// </returns>
        public static List<int> GetCoursesWithoutPrerequisites(Graph graph)
        {
            // Stores incoming edge count for every course.
            int[] indegree = new int[graph.Vertices];

            // Traverse the entire graph.
            foreach (var neighbours in graph.GetAdjacencyList())
            {
                foreach (var node in neighbours)
                {
                    // Every incoming edge increases indegree.
                    indegree[node]++;
                }
            }

            // Stores courses whose indegree equals zero.
            List<int> result = new();

            // Check every course.
            for (int i = 0; i < indegree.Length; i++)
            {
                // If indegree is zero,
                // no prerequisite exists.
                if (indegree[i] == 0)
                    result.Add(i);
            }

            return result;
        }

        //------------------------------------------------------------------
        // CountDirectDependents()
        //------------------------------------------------------------------

        /// <summary>
        /// Counts how many courses immediately depend
        /// on the given course.
        ///
        /// Example:
        ///
        /// 2 → 3
        /// 2 → 4
        ///
        /// Returns:
        /// 2
        /// </summary>
        ///
        /// <param name="graph">
        /// Course prerequisite graph.
        /// </param>
        ///
        /// <param name="course">
        /// Course whose dependents are counted.
        /// </param>
        ///
        /// <returns>
        /// Number of directly dependent courses.
        /// </returns>
        public static int CountDirectDependents(Graph graph, int course)
        {
            // Number of neighbours equals
            // number of directly dependent courses.
            return graph.GetNeighbours(course).Count;
        }

        //------------------------------------------------------------------
        // DFS()
        //------------------------------------------------------------------

        /// <summary>
        /// Performs Depth First Search recursively.
        ///
        /// DFS explores one complete path before
        /// backtracking.
        ///
        /// Used to collect all prerequisites.
        /// </summary>
        ///
        /// <param name="graph">
        /// Graph to traverse.
        /// </param>
        ///
        /// <param name="vertex">
        /// Current course being explored.
        /// </param>
        ///
        /// <param name="visited">
        /// Tracks already visited courses.
        /// </param>
        ///
        /// <param name="result">
        /// Stores discovered prerequisites.
        /// </param>
        private static void DFS(
            Graph graph,
            int vertex,
            bool[] visited,
            List<int> result)
        {
            // Visit every neighbouring course.
            foreach (var neighbour in graph.GetNeighbours(vertex))
            {
                // Skip already explored courses.
                if (visited[neighbour])
                    continue;

                // Mark neighbour as visited.
                visited[neighbour] = true;

                // Store prerequisite.
                result.Add(neighbour);

                // Continue DFS recursively.
                DFS(graph, neighbour, visited, result);
            }
        }

        //------------------------------------------------------------------
        // BuildReverseGraph()
        //------------------------------------------------------------------

        /// <summary>
        /// Creates a reverse version of the graph.
        ///
        /// Original Graph:
        ///
        /// 0 → 1
        ///
        /// Reverse Graph:
        ///
        /// 1 → 0
        ///
        /// Reversing edges allows prerequisite searching
        /// using DFS from the target course.
        /// </summary>
        ///
        /// <param name="graph">
        /// Original graph.
        /// </param>
        ///
        /// <returns>
        /// Reversed graph.
        /// </returns>
        private static Graph BuildReverseGraph(Graph graph)
        {
            // Create an empty graph with
            // the same number of vertices.
            Graph reverse = new(graph.Vertices);

            // Traverse every vertex.
            for (int i = 0; i < graph.Vertices; i++)
            {
                // Traverse every outgoing edge.
                foreach (var node in graph.GetNeighbours(i))
                {
                    // Reverse the direction.
                    //
                    // Original:
                    // i → node
                    //
                    // Reverse:
                    // node → i
                    reverse.AddEdge(node, i);
                }
            }

            // Return the reversed graph.
            return reverse;
        }
    }
}