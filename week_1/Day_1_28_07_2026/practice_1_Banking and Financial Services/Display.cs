using System;

namespace FraudDetectionSystem
{
    class Display
    {
        public static void Show(Transaction[] t)
        {
            Console.WriteLine("All Transaction");

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account ID : " + t[i].AccountId);
                Console.WriteLine("Amount     : " + t[i].TransactionAmount);
                Console.WriteLine("Time       : " + t[i].Timestamp);
                Console.WriteLine("Merchant   : " + t[i].MerchantName);
            }
        }
    }
}