using System.Collections.Generic;
using SocialNetworkSystem.Models;

namespace SocialNetworkSystem.Services
{
    /// <summary>
    /// The PathFinder class is responsible for finding
    /// the shortest path between two users in the social network.
    ///
    /// Since every friendship has equal weight,
    /// Breadth-First Search (BFS) always finds
    /// the shortest path.
    ///
    /// Example:
    ///
    /// 0 ----- 2 ----- 3 ----- 5
    ///
    /// Shortest Path:
    ///
    /// 0 → 2 → 3 → 5
    /// </summary>
    public static class PathFinder
    {
        //------------------------------------------------------------------
        // ShortestPath()
        //------------------------------------------------------------------

        /// <summary>
        /// Finds the shortest path between two users
        /// using Breadth-First Search (BFS).
        ///
        /// Algorithm Steps:
        ///
        /// 1. Start BFS from the source user.
        /// 2. Visit neighbours level by level.
        /// 3. Store each user's parent.
        /// 4. Stop when destination is found.
        /// 5. Reconstruct the path using parent information.
        /// </summary>
        ///
        /// <param name="graph">
        /// Social network graph.
        /// </param>
        ///
        /// <param name="source">
        /// Starting user.
        /// </param>
        ///
        /// <param name="destination">
        /// Target user.
        /// </param>
        ///
        /// <returns>
        /// List containing the shortest path.
        /// Returns an empty list if no path exists.
        /// </returns>
        public static List<int> ShortestPath(
            Graph graph,
            int source,
            int destination)
        {
            //----------------------------------------------------------
            // STEP 1
            // Create required data structures.
            //----------------------------------------------------------

            // Tracks visited users.
            bool[] visited = new bool[graph.Vertices];

            // Stores the parent of every user.
            // Used later to reconstruct the shortest path.
            int[] parent = new int[graph.Vertices];

            // Initialize parent array.
            for (int i = 0; i < graph.Vertices; i++)
            {
                parent[i] = -1;
            }

            // Queue used for BFS.
            Queue<int> queue = new();

            //----------------------------------------------------------
            // STEP 2
            // Begin BFS from the source user.
            //----------------------------------------------------------

            visited[source] = true;
            queue.Enqueue(source);

            //----------------------------------------------------------
            // STEP 3
            // Explore the graph level by level.
            //----------------------------------------------------------

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                // Destination found.
                if (current == destination)
                    break;

                // Visit neighbouring users.
                foreach (var neighbour in graph.GetFriends(current))
                {
                    if (!visited[neighbour])
                    {
                        visited[neighbour] = true;

                        // Store the parent.
                        parent[neighbour] = current;

                        queue.Enqueue(neighbour);
                    }
                }
            }

            //----------------------------------------------------------
            // STEP 4
            // If destination was never visited,
            // no path exists.
            //----------------------------------------------------------

            if (!visited[destination])
                return new List<int>();

            //----------------------------------------------------------
            // STEP 5
            // Reconstruct the shortest path.
            //----------------------------------------------------------

            List<int> path = new();

            int currentNode = destination;

            // Move backwards using parent[]
            // until the source is reached.
            while (currentNode != -1)
            {
                path.Add(currentNode);
                currentNode = parent[currentNode];
            }

            // Reverse the path because
            // it was built from destination to source.
            path.Reverse();

            return path;
        }
    }
}