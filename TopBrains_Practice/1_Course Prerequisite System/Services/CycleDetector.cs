using CoursePrerequisiteSystem.Models;

namespace CoursePrerequisiteSystem.Services
{
    /// <summary>
    /// The CycleDetector class is responsible for detecting cycles
    /// (circular dependencies) in a directed graph.
    ///
    /// In the Course Prerequisite System, a cycle means that a course
    /// directly or indirectly depends on itself.
    ///
    /// Example of a cycle:
    ///
    ///     Course 0 → Course 1
    ///     Course 1 → Course 2
    ///     Course 2 → Course 0
    ///
    /// Such a dependency is invalid because no course in the cycle
    /// can ever be completed first.
    ///
    /// This class uses the Depth First Search (DFS) algorithm
    /// along with a Recursion Stack to efficiently detect cycles.
    /// </summary>
    public static class CycleDetector
    {
        //------------------------------------------------------------------
        // HasCycle()
        //------------------------------------------------------------------

        /// <summary>
        /// Checks whether the graph contains any cycle.
        ///
        /// The method starts a DFS traversal from every vertex
        /// because the graph may contain multiple disconnected components.
        ///
        /// If any DFS traversal detects a cycle,
        /// the method immediately returns true.
        ///
        /// Otherwise, after checking all vertices,
        /// it returns false.
        /// </summary>
        ///
        /// <param name="graph">
        /// The directed graph representing course prerequisites.
        /// </param>
        ///
        /// <returns>
        /// True  → Cycle exists.
        /// False → No cycle exists.
        /// </returns>
        public static bool HasCycle(Graph graph)
        {
            // Keeps track of vertices that have already
            // been completely explored.
            bool[] visited = new bool[graph.Vertices];

            // Keeps track of vertices currently present
            // in the recursive DFS call stack.
            //
            // If a vertex is encountered again while it
            // already exists in this stack,
            // a cycle has been detected.
            bool[] recursionStack = new bool[graph.Vertices];

            // Start DFS from every vertex.
            // This ensures disconnected components
            // are also checked.
            for (int i = 0; i < graph.Vertices; i++)
            {
                // If a cycle is found,
                // stop immediately.
                if (Detect(graph, i, visited, recursionStack))
                    return true;
            }

            // Entire graph has been checked
            // and no cycle exists.
            return false;
        }

        //------------------------------------------------------------------
        // Detect()
        //------------------------------------------------------------------

        /// <summary>
        /// Performs a recursive Depth First Search (DFS)
        /// to detect cycles.
        ///
        /// The algorithm works by maintaining:
        ///
        /// visited[]
        ///     Stores vertices that have already been processed.
        ///
        /// recursionStack[]
        ///     Stores vertices currently being explored.
        ///
        /// If a vertex is visited while already present
        /// in recursionStack,
        /// then a cycle exists.
        /// </summary>
        ///
        /// <param name="graph">
        /// Graph containing prerequisite relationships.
        /// </param>
        ///
        /// <param name="vertex">
        /// Current vertex being explored.
        /// </param>
        ///
        /// <param name="visited">
        /// Tracks completely explored vertices.
        /// </param>
        ///
        /// <param name="recursionStack">
        /// Tracks vertices currently in the DFS path.
        /// </param>
        ///
        /// <returns>
        /// True if a cycle exists.
        /// Otherwise false.
        /// </returns>
        private static bool Detect(
            Graph graph,
            int vertex,
            bool[] visited,
            bool[] recursionStack)
        {
            //----------------------------------------------------------
            // STEP 1
            // Check whether the current vertex
            // already exists in the recursion stack.
            //----------------------------------------------------------

            // Example:
            //
            // 0 → 1 → 2 → 0
            //
            // While exploring Course 2,
            // Course 0 is found again
            // in the current DFS path.
            //
            // This confirms a circular dependency.
            if (recursionStack[vertex])
                return true;

            //----------------------------------------------------------
            // STEP 2
            // If the vertex has already been explored,
            // no need to process it again.
            //----------------------------------------------------------

            if (visited[vertex])
                return false;

            //----------------------------------------------------------
            // STEP 3
            // Mark the current vertex as visited.
            //----------------------------------------------------------

            // This prevents repeated processing
            // during future DFS traversals.
            visited[vertex] = true;

            //----------------------------------------------------------
            // STEP 4
            // Add the vertex to the recursion stack.
            //----------------------------------------------------------

            // This indicates that the vertex
            // is currently being explored.
            recursionStack[vertex] = true;

            //----------------------------------------------------------
            // STEP 5
            // Visit all neighbouring vertices.
            //----------------------------------------------------------

            foreach (var neighbour in graph.GetNeighbours(vertex))
            {
                // Recursively explore each neighbour.
                //
                // If any recursive call finds a cycle,
                // immediately return true.
                if (Detect(graph, neighbour, visited, recursionStack))
                    return true;
            }

            //----------------------------------------------------------
            // STEP 6
            // Remove the vertex from recursion stack.
            //----------------------------------------------------------

            // DFS exploration of this vertex
            // has completed successfully.
            recursionStack[vertex] = false;

            //----------------------------------------------------------
            // STEP 7
            // No cycle found from this vertex.
            //----------------------------------------------------------

            return false;
        }
    }
}