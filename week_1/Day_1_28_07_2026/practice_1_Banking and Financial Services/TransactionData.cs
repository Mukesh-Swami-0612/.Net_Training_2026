namespace FraudDetectionSystem
{
    class TransactionData
    {
        /// <summary>
        /// Creates and returns an array of sample transaction records
        /// used by the Fraud Detection System.
        /// </summary>
        public static Transaction[] GetTransactions()
        {
            // Create an array to store 5 Transaction objects.
            Transaction[] t = new Transaction[5];

            // Create the first transaction and store it at index 0.
            t[0] = new Transaction("ACC1001", 45000, "28-07-2026 09:30", "Amazon India");

            // Create the second transaction and store it at index 1.
            t[1] = new Transaction("ACC1002", 120000, "28-07-2026 09:45", "Reliance Digital");

            // Create the third transaction and store it at index 2.
            t[2] = new Transaction("ACC1001", 250, "28-07-2026 10:00", "Starbucks");

            // Create the fourth transaction and store it at index 3.
            t[3] = new Transaction("ACC1003", 65000, "28-07-2026 10:20", "Flipkart");

            // Create the fifth transaction and store it at index 4.
            t[4] = new Transaction("ACC1004", 250000, "28-07-2026 10:35", "Apple Store");

            // Return the array containing all transaction records.
            return t;
        }
    }
}