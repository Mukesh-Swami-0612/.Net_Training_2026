using System;
using System.Collections.Generic;

namespace Lab2Delegates;

public class Program
{
    public static void Main()
    {
        // Create the service containing the discount methods.
        DiscountService discountService = new DiscountService();

        // Common price used for all discount calculations.
        double price = 1000;

        Console.WriteLine("=== Direct Delegate Calls ===");

        // Pass NoDiscount as the delegate.
        double noDiscountResult =
            discountService.ApplyDiscount(
                price,
                discountService.NoDiscount);

        Console.WriteLine($"No Discount: {noDiscountResult:F2}");

        // Pass TenPercentOff as the delegate.
        double tenPercentResult =
            discountService.ApplyDiscount(
                price,
                discountService.TenPercentOff);

        Console.WriteLine($"10% Off: {tenPercentResult:F2}");

        // Pass HalfOff as the delegate.
        double halfOffResult =
            discountService.ApplyDiscount(
                price,
                discountService.HalfOff);

        Console.WriteLine($"50% Off: {halfOffResult:F2}");

        Console.WriteLine();
        Console.WriteLine("=== Delegate List ===");

        // Store all compatible methods as delegates.
        List<Discount> discounts =
        [
            discountService.NoDiscount,
            discountService.TenPercentOff,
            discountService.HalfOff
        ];

        // Execute every delegate in the list.
        foreach (Discount discount in discounts)
        {
            double result = discount(price);

            Console.WriteLine($"Result: {result:F2}");
        }
    }
}