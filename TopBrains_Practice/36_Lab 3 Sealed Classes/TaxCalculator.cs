using System;

public class TaxCalculator
{
    /// <summary>
    /// Calculates tax using the default 10% tax rate.
    /// </summary>
    public virtual decimal CalculateTax(decimal amount)
    {
        return amount * 0.10m;
    }
}

public class RegionalTaxCalculator : TaxCalculator
{
    /// <summary>
    /// Calculates tax using the regional 12% tax rate.
    /// The sealed keyword prevents further overriding.
    /// </summary>
    public sealed override decimal CalculateTax(decimal amount)
    {
        return amount * 0.12m;
    }
}

