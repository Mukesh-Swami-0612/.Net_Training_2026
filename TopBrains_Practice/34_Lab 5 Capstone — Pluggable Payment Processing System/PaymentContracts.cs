using System;

/// <summary>
/// Defines an object that has a unique identifier.
/// </summary>
public interface IIdentifiable
{
    /// <summary>
    /// Gets the unique ID.
    /// </summary>
    string Id { get; }
}

/// <summary>
/// Defines the common contract for all payment methods.
/// </summary>
public interface IPaymentMethod : IIdentifiable
{
    /// <summary>
    /// Gets the display name of the payment method.
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    /// Attempts to charge the specified amount.
    /// </summary>
    PaymentResult Charge(decimal amount);
}

/// <summary>
/// Represents the result of a payment operation.
/// </summary>
public class PaymentResult
{
    /// <summary>
    /// Indicates whether the payment was successful.
    /// </summary>
    public bool Success { get; }

    /// <summary>
    /// Gets the message describing the payment result.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Creates a payment result.
    /// </summary>
    public PaymentResult(bool success, string message)
    {
        // Message cannot be null
        if (message == null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        Success = success;
        Message = message;
    }
}