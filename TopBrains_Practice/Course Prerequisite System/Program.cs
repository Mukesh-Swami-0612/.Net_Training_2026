using System;

// Imports the Graph class, which represents the course dependency graph.
using CoursePrerequisiteSystem.Models;

// Imports all graph algorithm service classes such as
// GraphTraversal, CycleDetector, and TopologicalSorter.
using CoursePrerequisiteSystem.Services;

namespace CoursePrerequisiteSystem
{
    /// <summary>
    /// Entry point of the Course Prerequisite System application.
    ///
    /// Responsibilities:
    /// 1. Create the graph containing all courses.
    /// 2. Add prerequisite relationships between courses.
    /// 3. Execute different graph algorithms.
    /// 4. Display the results to the user.
    ///
    /// This class only controls the application flow.
    /// All graph-related logic is implemented inside the Services folder.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main() is the starting point of the console application.
        /// Program execution begins from this method.
        /// </summary>
        static void Main()
        {
            //----------------------------------------------------------
            // STEP 1 : Create Graph
            //----------------------------------------------------------

            // Create a graph with 6 vertices (courses).
            //
            // Course Numbers:
            // 0
            // 1
            // 2
            // 3
            // 4
            // 5
            //
            // Initially no prerequisite relationships exist.
            Graph graph = new Graph(6);

            //----------------------------------------------------------
            // STEP 2 : Add Prerequisite Relationships
            //----------------------------------------------------------

            // Course 1 requires Course 0.
            //
            // Graph Representation:
            // 0 → 1
            graph.AddEdge(0, 1);

            // Course 2 requires Course 0.
            //
            // Graph Representation:
            // 0 → 2
            graph.AddEdge(0, 2);

            // Course 3 requires Course 1.
            //
            // Graph Representation:
            // 1 → 3
            graph.AddEdge(1, 3);

            // Course 3 also requires Course 2.
            //
            // Graph Representation:
            // 2 → 3
            graph.AddEdge(2, 3);

            // Course 4 requires Course 2.
            //
            // Graph Representation:
            // 2 → 4
            graph.AddEdge(2, 4);

            // Course 5 requires Course 3.
            //
            // Graph Representation:
            // 3 → 5
            graph.AddEdge(3, 5);

            // Course 5 also requires Course 4.
            //
            // Graph Representation:
            // 4 → 5
            graph.AddEdge(4, 5);

            /*
                 Final Graph Structure

                        0
                      /   \
                     v     v
                    1       2
                     \     / \
                      v   v   v
                       3       4
                        \     /
                         \   /
                          \ /
                           v
                           5
            */

            //----------------------------------------------------------
            // Display Application Title
            //----------------------------------------------------------

            Console.WriteLine("====================================");
            Console.WriteLine("Course Prerequisite System");
            Console.WriteLine("====================================");

            //----------------------------------------------------------
            // TASK 1
            // Find all direct and indirect prerequisites of Course 5.
            //----------------------------------------------------------

            Console.WriteLine("\n1. All prerequisites of Course 5");

            // Calls DFS-based traversal on the reverse graph
            // to collect every prerequisite needed before Course 5.
            //
            // Expected Result:
            // 0, 1, 2, 3, 4
            var prerequisites =
                GraphTraversal.GetAllPrerequisites(graph, 5);

            // Print the prerequisite list.
            Console.WriteLine(string.Join(", ", prerequisites));

            //----------------------------------------------------------
            // TASK 2
            // Find only the immediate prerequisites of Course 3.
            //----------------------------------------------------------

            Console.WriteLine("\n2. Direct prerequisites of Course 3");

            // Returns only courses directly connected to Course 3.
            //
            // Expected Result:
            // 1, 2
            var direct =
                GraphTraversal.GetDirectPrerequisites(graph, 3);

            Console.WriteLine(string.Join(", ", direct));

            //----------------------------------------------------------
            // TASK 3
            // Detect whether the graph contains a cycle.
            //----------------------------------------------------------

            Console.WriteLine("\n3. Cycle Detection");

            // Executes DFS-based cycle detection.
            //
            // Returns:
            // true  -> Cycle exists
            // false -> No cycle
            bool hasCycle =
                CycleDetector.HasCycle(graph);

            // Print cycle detection result.
            Console.WriteLine(hasCycle
                ? "Cycle Found"
                : "No Cycle Found");

            //----------------------------------------------------------
            // TASK 4
            // Perform Topological Sort.
            //----------------------------------------------------------

            Console.WriteLine("\n4. Topological Sort");

            // Topological sorting is only possible
            // when no cycle exists.
            if (!hasCycle)
            {
                // Executes Kahn's Algorithm
                // to generate one valid course completion order.
                var order =
                    TopologicalSorter.Sort(graph);

                // Example Output:
                // 0 -> 1 -> 2 -> 3 -> 4 -> 5
                Console.WriteLine(string.Join(" -> ", order));
            }

            //----------------------------------------------------------
            // TASK 5
            // Find all courses having no prerequisites.
            //----------------------------------------------------------

            Console.WriteLine("\n5. Courses without prerequisites");

            // Courses with indegree = 0
            // can be taken immediately.
            var starters =
                GraphTraversal.GetCoursesWithoutPrerequisites(graph);

            Console.WriteLine(string.Join(", ", starters));

            //----------------------------------------------------------
            // TASK 6
            // Count direct dependents of Course 2.
            //----------------------------------------------------------

            Console.WriteLine("\n6. Direct dependents of Course 2");

            // Counts how many courses immediately depend on Course 2.
            //
            // Graph:
            // 2 → 3
            // 2 → 4
            //
            // Result:
            // 2
            int count =
                GraphTraversal.CountDirectDependents(graph, 2);

            Console.WriteLine(count);

            //----------------------------------------------------------
            // Display End of Program
            //----------------------------------------------------------

            
            Console.WriteLine("Program Executed Successfully");
            
        }
    }
}