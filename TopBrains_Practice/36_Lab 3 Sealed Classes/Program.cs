using System;

public class Program
{
    /// <summary>
    /// Main method where the application starts.
    /// </summary>
    public static void Main()
    {
        // Create RegionalTaxCalculator object
        RegionalTaxCalculator regionalTax = new RegionalTaxCalculator();

        // Calculate tax for 200
        decimal tax = regionalTax.CalculateTax(200);

        Console.WriteLine(
            $"RegionalTaxCalculator.CalculateTax(200) -> {tax:F2}"
        );

        // Create FixedDiscountCalculator object
        FixedDiscountCalculator discountCalculator =
            new FixedDiscountCalculator();

        // Apply discount to 50
        decimal discountedPrice =
            discountCalculator.ApplyDiscount(50);

        Console.WriteLine(
            $"FixedDiscountCalculator.ApplyDiscount(50) -> {discountedPrice:F2}"
        );
    }
}