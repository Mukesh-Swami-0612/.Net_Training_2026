namespace FraudDetectionSystem
{
    class Transaction
    {
        // Stores the unique account ID associated with the transaction.
        public string AccountId;

        // Stores the amount involved in the transaction.
        public double TransactionAmount;

        // Stores the date and time when the transaction occurred.
        public string Timestamp;

        // Stores the name of the merchant where the transaction was made.
        public string MerchantName;

        /// <summary>
        /// Initializes a new Transaction object by assigning
        /// the account details, transaction amount, timestamp,
        /// and merchant name.
        /// </summary>
        public Transaction(string accountId, double amount, string timestamp, string merchantName)
        {
            // Assign the account ID to the AccountId field.
            AccountId = accountId;

            // Assign the transaction amount to the TransactionAmount field.
            TransactionAmount = amount;

            // Assign the transaction timestamp to the Timestamp field.
            Timestamp = timestamp;

            // Assign the merchant name to the MerchantName field.
            MerchantName = merchantName;
        }
    }
}