namespace FraudDetectionSystem
{
    class Transaction
    {
        public string AccountId;
        public double TransactionAmount;
        public string Timestamp;
        public string MerchantName;

        public Transaction(string accountId, double amount, string timestamp, string merchantName)
        {
            AccountId = accountId;
            TransactionAmount = amount;
            Timestamp = timestamp;
            MerchantName = merchantName;
        }
    }
}