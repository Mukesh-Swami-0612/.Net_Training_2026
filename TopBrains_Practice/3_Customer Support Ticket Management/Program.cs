using System;
using CustomerSupportSystem.Models;
using CustomerSupportSystem.Services;

namespace CustomerSupportSystem
{
    /// <summary>
    /// Entry point of the Customer Support Ticket Management System.
    ///
    /// This application demonstrates the Queue (FIFO) data structure
    /// for managing customer support tickets.
    ///
    /// Tasks Performed:
    /// 1. Enqueue Tickets.
    /// 2. Display All Tickets.
    /// 3. Process First Ticket (Dequeue).
    /// 4. View Next Ticket (Peek).
    /// 5. Check Queue Count.
    /// 6. Search Ticket by ID.
    /// 7. Count Tickets by Issue Type.
    /// 8. Remove All Processed Tickets.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine(" Customer Support Ticket Management System");
            Console.WriteLine("==============================================");

            //----------------------------------------------------------
            // Create Queue Service
            //----------------------------------------------------------

            TicketQueueService service = new TicketQueueService();

            //----------------------------------------------------------
            // TASK 1
            // Enqueue Tickets
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 1 : Enqueue Tickets");

            service.EnqueueTicket(new Ticket(101, "Rahul", "Technical", "Internet connection issue"));
            service.EnqueueTicket(new Ticket(102, "Priya", "Billing", "Incorrect bill amount"));
            service.EnqueueTicket(new Ticket(103, "Amit", "Login", "Unable to login"));
            service.EnqueueTicket(new Ticket(104, "Neha", "Technical", "Application crashes"));
            service.EnqueueTicket(new Ticket(105, "Rohan", "Account", "Update profile details"));

            //----------------------------------------------------------
            // TASK 2
            // Display All Tickets
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 2 : Display All Tickets");

            service.DisplayTickets();

            //----------------------------------------------------------
            // TASK 3
            // Process First Ticket (Dequeue)
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 3 : Process First Ticket");

            service.ProcessTicket();

            //----------------------------------------------------------
            // TASK 4
            // View Next Ticket (Peek)
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 4 : View Next Ticket");

            service.ViewNextTicket();

            //----------------------------------------------------------
            // TASK 5
            // Check Queue Count
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 5 : Queue Count");

            Console.WriteLine($"Pending Tickets : {service.GetQueueCount()}");

            //----------------------------------------------------------
            // TASK 6
            // Search Ticket by ID
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 6 : Search Ticket By ID");

            Ticket ticket = service.SearchTicketById(104);

            if (ticket != null)
            {
                Console.WriteLine("Ticket Found");
                Console.WriteLine(ticket);
            }
            else
            {
                Console.WriteLine("Ticket Not Found");
            }

            //----------------------------------------------------------
            // TASK 7
            // Count Tickets by Issue Type
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 7 : Count Tickets By Issue Type");

            var issueCount = service.CountTicketsByIssueType();

            foreach (var issue in issueCount)
            {
                Console.WriteLine($"{issue.Key} : {issue.Value}");
            }

            //----------------------------------------------------------
            // TASK 8
            // Remove All Processed Tickets
            //----------------------------------------------------------

            Console.WriteLine("\nTASK 8 : Remove All Tickets");

            service.RemoveAllProcessedTickets();

            Console.WriteLine($"Remaining Tickets : {service.GetQueueCount()}");

            //----------------------------------------------------------
            // Program End
            //----------------------------------------------------------

            Console.WriteLine("\nProgram Executed Successfully.");
        }
    }
}