using System;
using System.Collections.Generic;
using System.Linq;
using CustomerSupportSystem.Models;

namespace CustomerSupportSystem.Services
{
    /// <summary>
    /// Manages customer support tickets using a Queue.
    ///
    /// Queue follows the FIFO (First-In, First-Out) principle,
    /// meaning the first ticket received is the first ticket processed.
    ///
    /// Responsibilities:
    /// • Add new tickets.
    /// • Display all tickets.
    /// • Process tickets.
    /// • View the next ticket.
    /// • Search tickets.
    /// • Count tickets by issue type.
    /// • Remove all processed tickets.
    /// </summary>
    public class TicketQueueService
    {
        //------------------------------------------------------------------
        // Private Data Member
        //------------------------------------------------------------------

        /// <summary>
        /// Queue that stores all customer support tickets.
        /// </summary>
        private readonly Queue<Ticket> tickets = new();

        //------------------------------------------------------------------
        // EnqueueTicket()
        //------------------------------------------------------------------

        /// <summary>
        /// Adds a new ticket to the end of the queue.
        /// </summary>
        ///
        /// <param name="ticket">
        /// Ticket to be added.
        /// </param>
        public void EnqueueTicket(Ticket ticket)
        {
            tickets.Enqueue(ticket);
            Console.WriteLine($"Ticket {ticket.TicketId} added successfully.");
        }

        //------------------------------------------------------------------
        // DisplayTickets()
        //------------------------------------------------------------------

        /// <summary>
        /// Displays all tickets currently in the queue.
        /// </summary>
        public void DisplayTickets()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            Console.WriteLine("\nCurrent Tickets:");

            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket);
            }
        }

        //------------------------------------------------------------------
        // ProcessTicket()
        //------------------------------------------------------------------

        /// <summary>
        /// Removes and processes the first ticket in the queue.
        /// </summary>
        ///
        /// <returns>
        /// Processed ticket or null if queue is empty.
        /// </returns>
        public Ticket ProcessTicket()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("No tickets to process.");
                return null;
            }

            Ticket processedTicket = tickets.Dequeue();

            Console.WriteLine($"\nProcessed Ticket: {processedTicket}");

            return processedTicket;
        }

        //------------------------------------------------------------------
        // ViewNextTicket()
        //------------------------------------------------------------------

        /// <summary>
        /// Displays the next ticket without removing it.
        /// </summary>
        ///
        /// <returns>
        /// Next ticket or null if queue is empty.
        /// </returns>
        public Ticket ViewNextTicket()
        {
            if (tickets.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            Ticket nextTicket = tickets.Peek();

            Console.WriteLine("\nNext Ticket:");
            Console.WriteLine(nextTicket);

            return nextTicket;
        }

        //------------------------------------------------------------------
        // GetQueueCount()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns the total number of tickets in the queue.
        /// </summary>
        ///
        /// <returns>
        /// Number of pending tickets.
        /// </returns>
        public int GetQueueCount()
        {
            return tickets.Count;
        }

        //------------------------------------------------------------------
        // SearchTicketById()
        //------------------------------------------------------------------

        /// <summary>
        /// Searches for a ticket using its Ticket ID.
        /// </summary>
        ///
        /// <param name="ticketId">
        /// Ticket ID to search.
        /// </param>
        ///
        /// <returns>
        /// Matching ticket or null if not found.
        /// </returns>
        public Ticket SearchTicketById(int ticketId)
        {
            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketId == ticketId)
                {
                    return ticket;
                }
            }

            return null;
        }

        //------------------------------------------------------------------
        // CountTicketsByIssueType()
        //------------------------------------------------------------------

        /// <summary>
        /// Counts the number of tickets belonging
        /// to each issue type.
        /// </summary>
        ///
        /// <returns>
        /// Dictionary containing issue type and count.
        /// </returns>
        public Dictionary<string, int> CountTicketsByIssueType()
        {
            Dictionary<string, int> issueCount = new();

            foreach (Ticket ticket in tickets)
            {
                if (issueCount.ContainsKey(ticket.IssueType))
                {
                    issueCount[ticket.IssueType]++;
                }
                else
                {
                    issueCount[ticket.IssueType] = 1;
                }
            }

            return issueCount;
        }

        //------------------------------------------------------------------
        // RemoveAllProcessedTickets()
        //------------------------------------------------------------------

        /// <summary>
        /// Removes all remaining tickets from the queue.
        /// </summary>
        public void RemoveAllProcessedTickets()
        {
            tickets.Clear();

            Console.WriteLine("\nAll tickets have been removed.");
        }
    }
}