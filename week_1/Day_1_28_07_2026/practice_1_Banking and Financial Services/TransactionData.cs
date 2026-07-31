namespace FraudDetectionSystem
{
    class TransactionData
    {
        public static Transaction[] GetTransactions()
        {
            Transaction[] t = new Transaction[5];

            t[0] = new Transaction("ACC1001", 45000, "28-07-2026 09:30", "Amazon India");
            t[1] = new Transaction("ACC1002", 120000, "28-07-2026 09:45", "Reliance Digital");
            t[2] = new Transaction("ACC1001", 250, "28-07-2026 10:00", "Starbucks");
            t[3] = new Transaction("ACC1003", 65000, "28-07-2026 10:20", "Flipkart");
            t[4] = new Transaction("ACC1004", 250000, "28-07-2026 10:35", "Apple Store");

            return t;
        }
    }
}