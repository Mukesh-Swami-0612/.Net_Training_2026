using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    /// <summary>
    /// Main method where the application starts.
    /// </summary>
    public static void Main()
    {
        // Create a list using the interface type.
        // This demonstrates polymorphism.
        List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>
        {
            new CreditCardPayment("CC-1", "Visa ...1234"),
            new CashPayment("CASH-1", "Cash Drawer")
        };

        // Amounts that will be attempted.
        decimal[] amounts =
        {
            1500.00m,
            6000.00m
        };

        // Create settlement report using LINQ and anonymous types.
        var settlementReport =
            from paymentMethod in paymentMethods
            from amount in amounts
            let result = paymentMethod.Charge(amount)
            select new
            {
                Id = paymentMethod.Id,
                DisplayName = paymentMethod.DisplayName,
                AmountAttempted = amount,
                Success = result.Success,
                Message = result.Message
            };

        // Print settlement report.
        foreach (var entry in settlementReport)
        {
            Console.WriteLine(
                $"{entry.Id}  " +
                $"{entry.DisplayName,-15} " +
                $"Attempted={entry.AmountAttempted:F2}  " +
                $"Success={entry.Success}"
            );
        }

        // Calculate the total amount successfully settled.
        decimal totalSuccessfullySettled = settlementReport
            .Where(entry => entry.Success)
            .Sum(entry => entry.AmountAttempted);

        Console.WriteLine();

        Console.WriteLine(
            $"Total successfully settled: {totalSuccessfullySettled:F2}"
        );
    }
}