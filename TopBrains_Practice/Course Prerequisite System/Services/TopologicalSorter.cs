using System.Collections.Generic;
using CoursePrerequisiteSystem.Models;

namespace CoursePrerequisiteSystem.Services
{
    /// <summary>
    /// The TopologicalSorter class is responsible for finding
    /// a valid order in which courses can be completed.
    ///
    /// It uses Kahn's Algorithm, which is based on the concept
    /// of indegree (number of incoming edges).
    ///
    /// In a Course Prerequisite System:
    ///
    ///     Prerequisite → Course
    ///
    /// A course can only be taken after all of its prerequisites
    /// have been completed.
    ///
    /// Topological Sorting guarantees that every prerequisite
    /// appears before its dependent course.
    ///
    /// Example:
    ///
    ///     0 → 1
    ///     0 → 2
    ///     1 → 3
    ///     2 → 3
    ///
    /// One valid topological order is:
    ///
    ///     0 → 1 → 2 → 3
    ///
    /// Note:
    /// Topological sorting is only possible for
    /// Directed Acyclic Graphs (DAGs).
    /// </summary>
    public static class TopologicalSorter
    {
        //------------------------------------------------------------------
        // Sort()
        //------------------------------------------------------------------

        /// <summary>
        /// Performs Topological Sorting using Kahn's Algorithm.
        ///
        /// Algorithm Steps:
        ///
        /// 1. Calculate indegree of every vertex.
        /// 2. Insert all vertices having indegree = 0 into a queue.
        /// 3. Remove one vertex from the queue.
        /// 4. Add it to the result.
        /// 5. Reduce indegree of its neighbours.
        /// 6. If any neighbour becomes 0,
        ///    insert it into the queue.
        /// 7. Repeat until the queue becomes empty.
        ///
        /// The final result represents one valid order
        /// to complete all courses.
        /// </summary>
        ///
        /// <param name="graph">
        /// Directed graph representing course prerequisites.
        /// </param>
        ///
        /// <returns>
        /// List containing a valid topological ordering
        /// of all courses.
        /// </returns>
        public static List<int> Sort(Graph graph)
        {
            //----------------------------------------------------------
            // STEP 1
            // Calculate indegree of every course.
            //----------------------------------------------------------

            // indegree[i] stores the number of prerequisites
            // required before Course i.
            int[] indegree = new int[graph.Vertices];

            // Traverse the complete graph.
            foreach (var neighbours in graph.GetAdjacencyList())
            {
                foreach (var node in neighbours)
                {
                    // Every incoming edge increases indegree.
                    indegree[node]++;
                }
            }

            //----------------------------------------------------------
            // STEP 2
            // Create a queue.
            //----------------------------------------------------------

            // The queue stores courses that currently
            // have no remaining prerequisites.
            Queue<int> queue = new();

            //----------------------------------------------------------
            // STEP 3
            // Insert all zero-indegree courses.
            //----------------------------------------------------------

            for (int i = 0; i < indegree.Length; i++)
            {
                // Courses with indegree = 0
                // can be taken immediately.
                if (indegree[i] == 0)
                    queue.Enqueue(i);
            }

            //----------------------------------------------------------
            // STEP 4
            // Store final topological order.
            //----------------------------------------------------------

            List<int> result = new();

            //----------------------------------------------------------
            // STEP 5
            // Process the queue until empty.
            //----------------------------------------------------------

            while (queue.Count > 0)
            {
                // Remove the first available course.
                int current = queue.Dequeue();

                // Add it to the final order.
                result.Add(current);

                //------------------------------------------------------
                // Reduce indegree of neighbouring courses.
                //------------------------------------------------------

                foreach (var neighbour in graph.GetNeighbours(current))
                {
                    // One prerequisite has now been completed,
                    // so decrease indegree.
                    indegree[neighbour]--;

                    // If all prerequisites are completed,
                    // add the course to the queue.
                    if (indegree[neighbour] == 0)
                        queue.Enqueue(neighbour);
                }
            }

            //----------------------------------------------------------
            // STEP 6
            // Return the valid course order.
            //----------------------------------------------------------

            return result;
        }
    }
}