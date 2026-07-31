using SocialNetworkSystem.Models;

namespace SocialNetworkSystem.Services
{
    /// <summary>
    /// The CycleDetector class detects whether an
    /// undirected graph contains a cycle.
    ///
    /// In a social network, a cycle exists when
    /// users are connected in a closed loop.
    ///
    /// Example:
    ///
    ///     0 ----- 1
    ///      \     |
    ///       \    |
    ///        \   |
    ///          2
    ///
    /// Cycle:
    /// 0 → 1 → 2 → 0
    ///
    /// The algorithm uses Depth First Search (DFS)
    /// and keeps track of the parent node to avoid
    /// falsely identifying the immediate back edge
    /// as a cycle.
    /// </summary>
    public static class CycleDetector
    {
        //------------------------------------------------------------------
        // HasCycle()
        //------------------------------------------------------------------

        /// <summary>
        /// Checks whether the social network graph
        /// contains a cycle.
        ///
        /// Since the graph may contain multiple
        /// disconnected friend groups,
        /// DFS starts from every unvisited user.
        /// </summary>
        ///
        /// <param name="graph">
        /// Social network graph.
        /// </param>
        ///
        /// <returns>
        /// True if a cycle exists.
        /// Otherwise false.
        /// </returns>
        public static bool HasCycle(Graph graph)
        {
            // Tracks users already visited during DFS.
            bool[] visited = new bool[graph.Vertices];

            // Check every connected component.
            for (int i = 0; i < graph.Vertices; i++)
            {
                if (!visited[i])
                {
                    // Parent of the starting node is -1.
                    if (Detect(graph, i, visited, -1))
                        return true;
                }
            }

            // No cycle found.
            return false;
        }

        //------------------------------------------------------------------
        // Detect()
        //------------------------------------------------------------------

        /// <summary>
        /// Performs recursive DFS to detect cycles.
        ///
        /// A cycle is found when a visited neighbour
        /// is encountered that is NOT the parent.
        ///
        /// Example:
        ///
        /// 0 ----- 1
        /// |       |
        /// |       |
        /// 2-------
        ///
        /// Starting DFS from 0:
        ///
        /// 0 → 1 → 2
        ///
        /// User 2 reaches User 0 again.
        ///
        /// Since 0 is not the parent of 2,
        /// a cycle exists.
        /// </summary>
        ///
        /// <param name="graph">
        /// Social network graph.
        /// </param>
        ///
        /// <param name="current">
        /// Current user being explored.
        /// </param>
        ///
        /// <param name="visited">
        /// Tracks visited users.
        /// </param>
        ///
        /// <param name="parent">
        /// Previous user in DFS traversal.
        /// </param>
        ///
        /// <returns>
        /// True if a cycle exists.
        /// Otherwise false.
        /// </returns>
        private static bool Detect(
            Graph graph,
            int current,
            bool[] visited,
            int parent)
        {
            //----------------------------------------------------------
            // STEP 1
            // Mark current user as visited.
            //----------------------------------------------------------

            visited[current] = true;

            //----------------------------------------------------------
            // STEP 2
            // Visit all neighbouring users.
            //----------------------------------------------------------

            foreach (var neighbour in graph.GetFriends(current))
            {
                //------------------------------------------------------
                // If neighbour is not visited,
                // continue DFS.
                //------------------------------------------------------

                if (!visited[neighbour])
                {
                    if (Detect(graph, neighbour, visited, current))
                        return true;
                }

                //------------------------------------------------------
                // If neighbour is already visited
                // and is NOT the parent,
                // a cycle has been found.
                //------------------------------------------------------

                else if (neighbour != parent)
                {
                    return true;
                }
            }

            //----------------------------------------------------------
            // STEP 3
            // No cycle detected from this path.
            //----------------------------------------------------------

            return false;
        }
    }
}