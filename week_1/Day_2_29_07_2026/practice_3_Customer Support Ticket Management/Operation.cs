using System;
using System.Collections.Generic;

namespace CustomerSupportTicketManagement
{
    class TicketOperations
    {
        // Queue used to store customer support tickets.
        static Queue<string> ticketQueue = new Queue<string>();

        /// <summary>
        /// Adds all customer support tickets to the queue
        /// and displays their ticket IDs.
        /// </summary>
        public static void EnqueueTickets(string[] tickets)
        {
            // Loop through each ticket in the array.
            foreach (string ticket in tickets)
            {
                // Add the ticket to the queue.
                ticketQueue.Enqueue(ticket);

                // Split the ticket into Ticket ID, Customer Name, and Issue.
                string[] data = ticket.Split('|');

                // Display the Ticket ID.
                Console.WriteLine(data[0]);
            }
        }

        /// <summary>
        /// Displays all tickets currently present in the queue.
        /// </summary>
        public static void DisplayQueue()
        {
            // Display the heading.
            Console.WriteLine("Queue");
            Console.WriteLine();

            // Loop through every ticket in the queue.
            foreach (string ticket in ticketQueue)
            {
                // Split the ticket details.
                string[] data = ticket.Split('|');

                // Display Ticket ID, Customer Name, and Issue.
                Console.WriteLine(data[0] + " " +
                                  data[1] + " " +
                                  data[2]);
            }
        }

        /// <summary>
        /// Displays the first ticket waiting in the queue.
        /// </summary>
        public static void ShowFirstTicket()
        {
            // Retrieve the first ticket without removing it.
            string ticket = ticketQueue.Peek();

            // Split the ticket details.
            string[] data = ticket.Split('|');

            // Display the ticket information.
            Console.WriteLine(data[0] + " " +
                              data[1] + " " +
                              data[2]);
        }

        /// <summary>
        /// Removes the current ticket and displays
        /// the next ticket in the queue.
        /// </summary>
        public static void ShowNextTicket()
        {
            // Check if another ticket exists.
            if (ticketQueue.Count > 1)
            {
                // Remove the first ticket.
                ticketQueue.Dequeue();

                // Retrieve the next ticket.
                string ticket = ticketQueue.Peek();

                // Split the ticket details.
                string[] data = ticket.Split('|');

                // Display the next ticket.
                Console.WriteLine(data[0] + " " +
                                  data[1] + " " +
                                  data[2]);
            }
            else
            {
                // Display a message if no next ticket exists.
                Console.WriteLine("No next ticket available.");
            }
        }

        /// <summary>
        /// Displays the total number of
        /// pending tickets in the queue.
        /// </summary>
        public static void CheckQueueCount()
        {
            // Display the number of pending tickets.
            Console.WriteLine("Pending Tickets = " + ticketQueue.Count);
        }

        /// <summary>
        /// Searches for a ticket using its Ticket ID
        /// and displays the ticket details if found.
        /// </summary>
        public static void SearchTicketById(string ticketId)
        {
            // Loop through all tickets.
            foreach (string ticket in ticketQueue)
            {
                // Split the ticket details.
                string[] data = ticket.Split('|');

                // Check if the Ticket ID matches.
                if (data[0] == ticketId)
                {
                    // Display the ticket details.
                    Console.WriteLine("Ticket Found");
                    Console.WriteLine("Customer : " + data[1]);
                    Console.WriteLine("Issue : " + data[2]);
                    return;
                }
            }

            // Display a message if the ticket is not found.
            Console.WriteLine("Ticket Not Found");
        }

        /// <summary>
        /// Counts and displays the number of tickets
        /// for each issue type.
        /// </summary>
        public static void CountTicketsByIssueType()
        {
            // Variables to count each issue type.
            int loginIssue = 0;
            int paymentFailed = 0;
            int refundRequest = 0;

            // Loop through all tickets.
            foreach (string ticket in ticketQueue)
            {
                // Split the ticket details.
                string[] data = ticket.Split('|');

                // Count Login Issue tickets.
                if (data[2] == "Login Issue")
                {
                    loginIssue++;
                }
                // Count Payment Failed tickets.
                else if (data[2] == "Payment Failed")
                {
                    paymentFailed++;
                }
                // Count Refund Request tickets.
                else if (data[2] == "Refund Request")
                {
                    refundRequest++;
                }
            }

            // Display the count of each issue type.
            Console.WriteLine("Login Issue = " + loginIssue);
            Console.WriteLine("Payment Failed = " + paymentFailed);
            Console.WriteLine("Refund Request = " + refundRequest);
        }

        /// <summary>
        /// Searches for a ticket using the customer's name
        /// and displays the ticket details if found.
        /// </summary>
        public static void SearchTicketByName(string name)
        {
            // Loop through all tickets.
            foreach (string ticket in ticketQueue)
            {
                // Split the ticket details.
                string[] data = ticket.Split('|');

                // Compare customer names without considering case.
                if (data[1].ToLower() == name.ToLower())
                {
                    // Display the ticket details.
                    Console.WriteLine("Ticket Found");
                    Console.WriteLine("Ticket ID : " + data[0]);
                    Console.WriteLine("Customer : " + data[1]);
                    Console.WriteLine("Issue : " + data[2]);
                    return;
                }
            }

            // Display a message if the customer is not found.
            Console.WriteLine("Ticket Not Found");
        }
    }
}