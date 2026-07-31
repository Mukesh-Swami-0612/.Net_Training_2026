using System.Collections.Generic;
using SocialNetworkSystem.Models;

namespace SocialNetworkSystem.Services
{
    /// <summary>
    /// The ConnectedComponents class finds all connected
    /// components (friend groups) in the social network.
    ///
    /// A connected component is a group of users where
    /// every user can reach every other user through
    /// one or more friendships.
    ///
    /// Example:
    ///
    /// Component 1:
    /// 0 ----- 1 ----- 2
    ///
    /// Component 2:
    /// 3 ----- 4
    ///
    /// User 5
    ///
    /// Result:
    ///
    /// {0,1,2}
    /// {3,4}
    /// {5}
    ///
    /// This implementation uses Depth-First Search (DFS).
    /// </summary>
    public static class ConnectedComponents
    {
        //------------------------------------------------------------------
        // GetComponents()
        //------------------------------------------------------------------

        /// <summary>
        /// Finds every connected component (friend group)
        /// in the graph.
        ///
        /// Algorithm:
        ///
        /// 1. Visit every user.
        /// 2. If the user is unvisited,
        ///    start DFS.
        /// 3. DFS discovers the complete friend group.
        /// 4. Store the group.
        /// 5. Continue until every user is visited.
        /// </summary>
        ///
        /// <param name="graph">
        /// Social network graph.
        /// </param>
        ///
        /// <returns>
        /// A list containing all connected components.
        /// Each component is represented as a list of users.
        /// </returns>
        public static List<List<int>> GetComponents(Graph graph)
        {
            //----------------------------------------------------------
            // STEP 1
            // Create visited array.
            //----------------------------------------------------------

            bool[] visited = new bool[graph.Vertices];

            //----------------------------------------------------------
            // STEP 2
            // Store all connected components.
            //----------------------------------------------------------

            List<List<int>> components = new();

            //----------------------------------------------------------
            // STEP 3
            // Traverse every user.
            //----------------------------------------------------------

            for (int i = 0; i < graph.Vertices; i++)
            {
                // If the user is not visited,
                // a new connected component begins.
                if (!visited[i])
                {
                    List<int> component = new();

                    // Discover the complete friend group.
                    DFS(graph, i, visited, component);

                    // Store the discovered component.
                    components.Add(component);
                }
            }

            //----------------------------------------------------------
            // STEP 4
            // Return all friend groups.
            //----------------------------------------------------------

            return components;
        }

        //------------------------------------------------------------------
        // DFS()
        //------------------------------------------------------------------

        /// <summary>
        /// Performs recursive Depth-First Search (DFS)
        /// to discover every user belonging to the same
        /// connected component.
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
        /// <param name="component">
        /// Stores users in the current friend group.
        /// </param>
        private static void DFS(
            Graph graph,
            int current,
            bool[] visited,
            List<int> component)
        {
            //----------------------------------------------------------
            // STEP 1
            // Mark current user as visited.
            //----------------------------------------------------------

            visited[current] = true;

            //----------------------------------------------------------
            // STEP 2
            // Add user to current component.
            //----------------------------------------------------------

            component.Add(current);

            //----------------------------------------------------------
            // STEP 3
            // Visit all neighbouring users.
            //----------------------------------------------------------

            foreach (var neighbour in graph.GetFriends(current))
            {
                if (!visited[neighbour])
                {
                    DFS(graph, neighbour, visited, component);
                }
            }
        }
    }
}