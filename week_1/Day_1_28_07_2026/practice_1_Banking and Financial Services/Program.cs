using System;

namespace FraudDetectionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction[] t = TransactionData.GetTransactions();

            Display.Show(t);

        }
    }
}