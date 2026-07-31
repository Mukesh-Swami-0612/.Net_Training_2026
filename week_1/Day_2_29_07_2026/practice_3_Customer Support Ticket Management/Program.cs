using System;

namespace CustomerSupportTicketManagement
{
    class Program
    {
        /// <summary>
        /// Entry point of the Customer Support Ticket Management application.
        /// Creates sample tickets, adds them to the queue,
        /// and performs various queue operations such as displaying,
        /// searching, counting, and processing support tickets.
        /// </summary>
        static void Main(string[] args)
        {
            // Create an array of sample customer support tickets.
            string[] tickets =
            {
                "T001|John|Login Issue",
                "T002|Alice|Payment Failed",
                "T003|David|Account Locked",
                "T004|Emma|Refund Request",
                "T005|James|Password Reset"
            };

            // Display Task 1 heading.
            Console.WriteLine("Task 1: Enqueue Tickets");

            // Add all tickets to the queue.
            TicketOperations.EnqueueTickets(tickets);

            Console.WriteLine();

            // Display all tickets in the queue.
            // Console.WriteLine("Task 2: Display All Tickets");
            // TicketOperations.DisplayQueue();

            // Console.WriteLine();

            // Display the first ticket in the queue.
            // Console.WriteLine("Task 3: Show First Ticket");
            // TicketOperations.ShowFirstTicket();

            // Console.WriteLine();

            // Remove the first ticket and display the next ticket.
            // Console.WriteLine("Task 4: Show Next Ticket");
            // TicketOperations.ShowNextTicket();

            // Console.WriteLine();

            // Display the total number of pending tickets.
            // Console.WriteLine("Task 5: Check Queue Count");
            // TicketOperations.CheckQueueCount();

            // Console.WriteLine();

            // Search for a ticket using its Ticket ID.
            // Console.WriteLine("Task 6: Search Ticket by ID");
            // Console.Write("Enter Ticket ID: ");
            // string id = Console.ReadLine();
            // TicketOperations.SearchTicketById(id);

            // Console.WriteLine();

            // Count tickets based on their issue type.
            // Console.WriteLine("Task 7: Count Tickets by Issue Type");
            // TicketOperations.CountTicketsByIssueType();

            // Console.WriteLine();

            // Display the remaining tickets in the queue.
            // Console.WriteLine("Task 8: Remove All Processed Tickets");
            // TicketOperations.DisplayRemainingQueue();

            // Display the customer name search heading.
            Console.WriteLine();
            Console.WriteLine("Search Ticket by Customer Name");

            // Read the customer name.
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            // Search for the customer's ticket.
            TicketOperations.SearchTicketByName(name);
        }
    }
}