using System;

public sealed class FixedDiscountCalculator
{
    /// <summary>
    /// Applies a 10% discount to the given price.
    /// </summary>
    public decimal ApplyDiscount(decimal price)
    {
        return price * 0.90m;
    }
}

