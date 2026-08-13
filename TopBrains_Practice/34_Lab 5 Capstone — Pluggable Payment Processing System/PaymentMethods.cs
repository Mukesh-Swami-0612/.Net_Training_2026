using System;

/// <summary>
/// Provides common functionality for payment methods.
/// </summary>
public abstract class PaymentMethodBase : IPaymentMethod
{
    /// <summary>
    /// Gets the unique payment method ID.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Gets the display name of the payment method.
    /// </summary>
    public string DisplayName { get; }

    /// <summary>
    /// Initializes a payment method.
    /// </summary>
    protected PaymentMethodBase(string id, string displayName)
    {
        Id = id;
        DisplayName = displayName;
    }

    /// <summary>
    /// Charges the specified amount.
    /// Derived classes must provide the implementation.
    /// </summary>
    public abstract PaymentResult Charge(decimal amount);
}

/// <summary>
/// Represents a credit card payment method.
/// </summary>
public class CreditCardPayment : PaymentMethodBase
{
    /// <summary>
    /// Initializes a credit card payment method.
    /// </summary>
    public CreditCardPayment(string id, string displayName)
        : base(id, displayName)
    {
    }

    /// <summary>
    /// Charges the credit card.
    /// Payments over 5000 fail.
    /// </summary>
    public override PaymentResult Charge(decimal amount)
    {
        // Reject invalid or zero amounts
        if (amount <= 0)
        {
            return new PaymentResult(
                false,
                "Amount must be greater than zero."
            );
        }

        // Credit card limit for this example
        if (amount > 5000)
        {
            return new PaymentResult(
                false,
                "Credit card payment cannot exceed 5000."
            );
        }

        return new PaymentResult(
            true,
            "Credit card payment successful."
        );
    }
}

/// <summary>
/// Represents a cash payment method.
/// This class cannot be inherited.
/// </summary>
public sealed class CashPayment : PaymentMethodBase
{
    /// <summary>
    /// Initializes a cash payment method.
    /// </summary>
    public CashPayment(string id, string displayName)
        : base(id, displayName)
    {
    }

    /// <summary>
    /// Charges the cash payment method.
    /// Cash payments always succeed for positive amounts.
    /// </summary>
    public override PaymentResult Charge(decimal amount)
    {
        if (amount <= 0)
        {
            return new PaymentResult(
                false,
                "Amount must be greater than zero."
            );
        }

        return new PaymentResult(
            true,
            "Cash payment successful."
        );
    }
}