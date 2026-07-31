using System;

namespace CustomerSupportSystem.Models
{
    /// <summary>
    /// Represents a customer support ticket.
    ///
    /// Each ticket contains information about
    /// the customer request submitted to the
    /// support center.
    ///
    /// Tickets are processed in the order
    /// they are received (FIFO).
    /// </summary>
    public class Ticket
    {
        //------------------------------------------------------------------
        // Properties
        //------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the unique Ticket ID.
        /// </summary>
        public int TicketId { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the issue type.
        ///
        /// Example:
        /// Billing
        /// Technical
        /// Login
        /// Account
        /// </summary>
        public string IssueType { get; set; }

        /// <summary>
        /// Gets or sets the ticket description.
        /// </summary>
        public string Description { get; set; }

        //------------------------------------------------------------------
        // Constructor
        //------------------------------------------------------------------

        /// <summary>
        /// Initializes a new support ticket.
        /// </summary>
        ///
        /// <param name="ticketId">
        /// Unique ticket number.
        /// </param>
        ///
        /// <param name="customerName">
        /// Name of the customer.
        /// </param>
        ///
        /// <param name="issueType">
        /// Category of issue.
        /// </param>
        ///
        /// <param name="description">
        /// Detailed issue description.
        /// </param>
        public Ticket(
            int ticketId,
            string customerName,
            string issueType,
            string description)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            IssueType = issueType;
            Description = description;
        }

        //------------------------------------------------------------------
        // ToString()
        //------------------------------------------------------------------

        /// <summary>
        /// Returns ticket information in a readable format.
        /// </summary>
        public override string ToString()
        {
            return $"ID: {TicketId} | Customer: {CustomerName} | Issue: {IssueType} | Description: {Description}";
        }
    }
}