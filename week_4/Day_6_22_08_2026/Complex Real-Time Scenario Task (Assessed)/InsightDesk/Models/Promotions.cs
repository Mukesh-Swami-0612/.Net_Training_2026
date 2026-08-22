namespace InsightDesk.Models;

/// <summary>
/// Base class for all promotion types.
/// </summary>
public abstract class Promotion
{
    /// <summary>
    /// Gets or sets the promotion code.
    /// </summary>
    public string Code { get; set; } = string.Empty;
}

/// <summary>
/// Represents a percentage-based discount promotion.
/// </summary>
public class PercentOffPromotion : Promotion
{
    /// <summary>
    /// Gets or sets the percentage discount.
    /// </summary>
    public double PercentOff { get; set; }
}

/// <summary>
/// Represents a fixed monetary discount promotion.
/// </summary>
public class FlatAmountPromotion : Promotion
{
    /// <summary>
    /// Gets or sets the fixed amount discounted.
    /// </summary>
    public decimal AmountOff { get; set; }
}

/// <summary>
/// Represents a buy-one-get-one promotion.
/// </summary>
public class BuyOneGetOnePromotion : Promotion
{
}