using System;
using SocialNetworkSystem.Models;
using SocialNetworkSystem.Services;

namespace SocialNetworkSystem
{
    /// <summary>
    /// Entry point of the Social Network Friend Recommendation System.
    ///
    /// This program demonstrates various graph algorithms on an
    /// undirected and unweighted graph representing friendships.
    ///
    /// Tasks Performed:
    /// 1. Create a social network.
    /// 2. Add friendships.
    /// 3. Find friends of a user.
    /// 4. Check connectivity between two users.
    /// 5. Find the shortest friendship path.
    /// 6. Find users at a specific friendship distance.
    /// 7. Detect cycles.
    /// 8. Find connected components (friend groups).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine(" Social Network Friend Recommendation ");
            Console.WriteLine("==========================================");

            //----------------------------------------------------------
            // STEP 1
            // Create a graph with 6 users (0–5).
            //----------------------------------------------------------

            Graph graph = new Graph(6);

            //----------------------------------------------------------
            // STEP 2
            // Add friendships.
            //
            // Graph:
            //
            //          0
            //        /   \
            //       1     2
            //        \   / \
            //         \ /   \
            //          3-----4
            //           \   /
            //            \ /
            //             5
            //----------------------------------------------------------

            graph.AddFriendship(0, 1);
            graph.AddFriendship(0, 2);
            graph.AddFriendship(1, 3);
            graph.AddFriendship(2, 3);
            graph.AddFriendship(2, 4);
            graph.AddFriendship(3, 5);
            graph.AddFriendship(4, 5);

            //----------------------------------------------------------
            // TASK 1
            // Find all friends of User 2.
            //----------------------------------------------------------

            Console.WriteLine("\nFriends of User 2:");

            foreach (var friend in GraphTraversal.GetFriends(graph, 2))
            {
                Console.Write(friend + " ");
            }

            //----------------------------------------------------------
            // TASK 2
            // Check if User 0 and User 5 are connected.
            //----------------------------------------------------------

            Console.WriteLine("\n\nAre User 0 and User 5 Connected?");

            bool connected = GraphTraversal.AreConnected(graph, 0, 5);

            Console.WriteLine(connected ? "Yes" : "No");

            //----------------------------------------------------------
            // TASK 3
            // Find shortest path.
            //----------------------------------------------------------

            Console.WriteLine("\nShortest Path (0 → 5):");

            var path = PathFinder.ShortestPath(graph, 0, 5);

            Console.WriteLine(string.Join(" -> ", path));

            //----------------------------------------------------------
            // TASK 4
            // Users exactly 2 friendships away from User 1.
            //----------------------------------------------------------

            Console.WriteLine("\nUsers at Distance 2 from User 1:");

            foreach (var user in GraphTraversal.GetUsersAtDistance(graph, 1, 2))
            {
                Console.Write(user + " ");
            }

            //----------------------------------------------------------
            // TASK 5
            // Detect cycle.
            //----------------------------------------------------------

            Console.WriteLine("\n\nCycle Present?");

            bool cycle = CycleDetector.HasCycle(graph);

            Console.WriteLine(cycle ? "Yes" : "No");

            //----------------------------------------------------------
            // TASK 6
            // Find connected components.
            //----------------------------------------------------------

            Console.WriteLine("\nConnected Components:");

            var components = ConnectedComponents.GetComponents(graph);

            int componentNumber = 1;

            foreach (var component in components)
            {
                Console.Write($"Component {componentNumber}: ");

                foreach (var user in component)
                {
                    Console.Write(user + " ");
                }

                Console.WriteLine();

                componentNumber++;
            }

            //----------------------------------------------------------
            // End of Program.
            //----------------------------------------------------------

            Console.WriteLine("\nProgram Executed Successfully.");
        }
    }
}