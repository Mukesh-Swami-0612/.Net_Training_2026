using System;

namespace FraudDetectionSystem
{
    class Program
    {
        /// <summary>
        /// Entry point of the Fraud Detection System application.
        /// Retrieves the list of transactions and displays
        /// all transaction details on the console.
        /// </summary>

        static void Main(string[] args)
        {
            // Retrieve all transactions.
            Transaction[] t = TransactionData.GetTransactions();

            // Display all transactions.
            Display.Show(t);
        }
    }
}