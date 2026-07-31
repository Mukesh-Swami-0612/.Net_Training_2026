using System;
using System.Collections.Generic;

namespace SocialNetworkSystem.Models
{
    /// <summary>
    /// Represents an undirected and unweighted graph using an adjacency list.
    ///
    /// In this Social Network System:
    /// - Each vertex represents a user.
    /// - Each edge represents a friendship.
    /// - Friendships are mutual, meaning if User A is a friend of User B,
    ///   then User B is also a friend of User A.
    ///
    /// Example:
    ///     0 ----- 1
    ///
    /// This means User 0 and User 1 are friends.
    ///
    /// The Graph class serves as the foundation for all graph operations,
    /// including BFS, DFS, shortest path, cycle detection,
    /// and connected component analysis.
    /// </summary>
    public class Graph
    {
        //------------------------------------------------------------------
        // Private Data Members
        //------------------------------------------------------------------

        /// <summary>
        /// Stores the graph using an adjacency list.
        ///
        /// Each index represents one user.
        ///
        /// Example:
        ///
        /// adjacencyList[2] = {0,3,4}
        ///
        /// Means:
        /// User 2 is directly connected with
        /// User 0
        /// User 3
        /// User 4
        /// </summary>
        private readonly List<int>[] adjacencyList;

        //------------------------------------------------------------------
        // Public Properties
        //------------------------------------------------------------------

        /// <summary>
        /// Gets the total number of users in the social network.
        /// </summary>
        public int Vertices { get; }

        //------------------------------------------------------------------
        // Constructor
        //------------------------------------------------------------------

        /// <summary>
        /// Initializes the graph with the specified number of users.
        ///
        /// Initially every user has an empty friend list.
        /// </summary>
        /// <param name="vertices">
        /// Total number of users.
        /// </param>
        public Graph(int vertices)
        {
            // Store total number of users.
            Vertices = vertices;

            // Create an array of friend lists.
            adjacencyList = new List<int>[vertices];

            // Initialize an empty friend list for every user.
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        //------------------------------------------------------------------
        // AddFriendship()
        //------------------------------------------------------------------

        /// <summary>
        /// Creates a friendship between two users.
        ///
        /// Since the graph is undirected,
        /// both users are added to each other's friend list.
        ///
        /// Example:
        ///
        /// AddFriendship(2,4)
        ///
        /// Creates:
        ///
        /// 2 ----- 4
        /// </summary>
        /// <param name="user1">
        /// First user.
        /// </param>
        /// <param name="user2">
        /// Second user.
        /// </param>
        public void AddFriendship(int user1, int user2)
        {
            // Add User2 to User1's friend list.
            adjacencyList[user1].Add(user2);

            // Add User1 to User2's friend list.
            adjacencyList[user2].Add(user1);
        }

        //------------------------------------------------------------------
        // GetFriends()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns all direct friends of the specified user.
        ///
        /// Example:
        ///
        /// User 2 friends:
        ///
        /// 0
        /// 3
        /// 4
        ///
        /// Returns:
        /// {0,3,4}
        /// </summary>
        /// <param name="user">
        /// User whose friends are required.
        /// </param>
        /// <returns>
        /// List of direct friends.
        /// </returns>
        public List<int> GetFriends(int user)
        {
            return adjacencyList[user];
        }

        //------------------------------------------------------------------
        // GetAdjacencyList()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns the complete adjacency list.
        ///
        /// This method is used by graph algorithms
        /// such as BFS, DFS, cycle detection,
        /// shortest path, and connected components.
        /// </summary>
        /// <returns>
        /// Complete graph structure.
        /// </returns>
        public List<int>[] GetAdjacencyList()
        {
            return adjacencyList;
        }
    }
}