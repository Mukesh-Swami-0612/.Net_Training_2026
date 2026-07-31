using System.Collections.Generic;
using SocialNetworkSystem.Models;

namespace SocialNetworkSystem.Services
{
    /// <summary>
    /// Provides graph traversal operations for the social network.
    ///
    /// Responsibilities:
    /// • Retrieve direct friends of a user.
    /// • Check whether two users are connected.
    /// • Find users at a specific friendship distance.
    ///
    /// This class uses Breadth-First Search (BFS) because BFS explores
    /// the graph level by level, making it ideal for shortest-distance
    /// and connectivity-related operations.
    /// </summary>
    public static class GraphTraversal
    {
        //------------------------------------------------------------------
        // GetFriends()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns all direct friends of a user.
        ///
        /// Example:
        ///
        /// 0 ----- 2 ----- 3
        ///          |
        ///          |
        ///          4
        ///
        /// Calling:
        /// GetFriends(graph,2)
        ///
        /// Returns:
        /// {0,3,4}
        /// </summary>
        ///
        /// <param name="graph">
        /// Social network graph.
        /// </param>
        ///
        /// <param name="user">
        /// User whose friends are required.
        /// </param>
        ///
        /// <returns>
        /// List of direct friends.
        /// </returns>
        public static List<int> GetFriends(Graph graph, int user)
        {
            // Simply return the user's adjacency list.
            return graph.GetFriends(user);
        }

        //------------------------------------------------------------------
        // AreConnected()
        //------------------------------------------------------------------

        /// <summary>
        /// Determines whether two users are connected,
        /// either directly or through mutual friends.
        ///
        /// Algorithm:
        /// Breadth-First Search (BFS)
        ///
        /// Example:
        ///
        /// 0 ----- 2 ----- 3 ----- 5
        ///
        /// User 0 and User 5 are connected.
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
        /// User to search for.
        /// </param>
        ///
        /// <returns>
        /// True if connected.
        /// Otherwise false.
        /// </returns>
        public static bool AreConnected(Graph graph, int source, int destination)
        {
            // Track visited users.
            bool[] visited = new bool[graph.Vertices];

            // Queue used for BFS traversal.
            Queue<int> queue = new();

            // Start traversal from the source user.
            visited[source] = true;
            queue.Enqueue(source);

            // Continue until every reachable user is explored.
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                // Destination found.
                if (current == destination)
                    return true;

                // Visit all neighbouring users.
                foreach (var neighbour in graph.GetFriends(current))
                {
                    if (!visited[neighbour])
                    {
                        visited[neighbour] = true;
                        queue.Enqueue(neighbour);
                    }
                }
            }

            // Destination cannot be reached.
            return false;
        }

        //------------------------------------------------------------------
        // GetUsersAtDistance()
        //------------------------------------------------------------------

        /// <summary>
        /// Finds all users exactly 'distance' friendships away
        /// from a given user.
        ///
        /// Example:
        ///
        /// 0 ----- 1 ----- 3
        ///        |
        ///        |
        ///        2
        ///
        /// Distance from User 1
        ///
        /// Distance 1:
        /// 0,2,3
        ///
        /// Distance 2:
        /// Friends of friends.
        ///
        /// Algorithm:
        /// Breadth-First Search (BFS)
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
        /// <param name="distance">
        /// Required friendship distance.
        /// </param>
        ///
        /// <returns>
        /// List of users exactly at the specified distance.
        /// </returns>
        public static List<int> GetUsersAtDistance(Graph graph, int source, int distance)
        {
            // Stores visited users.
            bool[] visited = new bool[graph.Vertices];

            // Stores each user along with its current distance.
            Queue<(int User, int Distance)> queue = new();

            // Final result.
            List<int> result = new();

            // Begin BFS.
            visited[source] = true;
            queue.Enqueue((source, 0));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                // User found at required distance.
                if (current.Distance == distance)
                {
                    result.Add(current.User);

                    // Do not explore deeper.
                    continue;
                }

                // Visit neighbouring users.
                foreach (var neighbour in graph.GetFriends(current.User))
                {
                    if (!visited[neighbour])
                    {
                        visited[neighbour] = true;

                        queue.Enqueue((neighbour, current.Distance + 1));
                    }
                }
            }

            return result;
        }
    }
}