using System;

// Base custom exception for all order validation errors.
public class OrderValidationException : Exception
{
    // Stores the name of the field that caused the validation error.
    public string FieldName { get; }

    // Default constructor.
    public OrderValidationException() : base()
    {
    }

    // Constructor that accepts only an error message.
    public OrderValidationException(string message) : base(message)
    {
    }

    // Constructor used for exception wrapping.
    // The inner exception contains the original lower-level error.
    public OrderValidationException(string message, Exception inner)
        : base(message, inner)
    {
    }

    // Constructor that accepts a message and field name.
    public OrderValidationException(string message, string fieldName)
        : base(message)
    {
        FieldName = fieldName;
    }
}


// More specific exception for missing fields.
public class MissingFieldException : OrderValidationException
{
    // Constructor receives the field name and sets a clear message.
    public MissingFieldException(string fieldName)
        : base($"Missing field: {fieldName}", fieldName)
    {
    }
}


// More specific exception for invalid quantity.
public class InvalidQuantityException : OrderValidationException
{
    // Constructor receives the invalid field name and sets a clear message.
    public InvalidQuantityException(string fieldName)
        : base("Quantity must be greater than zero.", fieldName)
    {
    }
}


public class OrderProcessor
{
    // Validates the order before processing it.
    // Returns the calculated order total if validation succeeds.
    public decimal ValidateOrder(
        string customerName,
        int quantity,
        decimal unitPrice)
    {
        // Check whether customer name is missing.
        if (string.IsNullOrWhiteSpace(customerName))
        {
            throw new MissingFieldException("customerName");
        }

        // Check whether quantity is valid.
        if (quantity <= 0)
        {
            throw new InvalidQuantityException("quantity");
        }

        // Check whether unit price is negative.
        if (unitPrice < 0)
        {
            throw new OrderValidationException(
                "Unit price cannot be negative",
                "unitPrice");
        }

        // Calculate and return the order total.
        return quantity * unitPrice;
    }


    // Simulates saving the order to a database.
    // For demonstration, one specific customer causes a database failure.
    public void SaveOrder(
        string customerName,
        int quantity,
        decimal unitPrice)
    {
        // This condition allows us to demonstrate the database failure path.
        if (customerName == "DatabaseFailure")
        {
            throw new InvalidOperationException("Database unavailable");
        }

        // If there is no simulated failure, the order is considered saved.
        Console.WriteLine("Order saved successfully.");
    }


    // Processes the complete order-validation pipeline.
    public void ProcessOrder(
        string customerName,
        int quantity,
        decimal unitPrice)
    {
        try
        {
            // First validate the order.
            decimal total = ValidateOrder(
                customerName,
                quantity,
                unitPrice);

            try
            {
                // Save the order only after validation succeeds.
                SaveOrder(
                    customerName,
                    quantity,
                    unitPrice);
            }
            catch (InvalidOperationException ex)
            {
                // The database error is a lower-level exception.
                // We wrap it inside our application-specific exception.
                //
                // IMPORTANT:
                // We cannot use "throw;" here because "throw;" rethrows
                // the exception currently being caught.
                //
                // Here we are throwing a BRAND NEW exception object,
                // so we use "throw new ...".
                throw new OrderValidationException(
                    "Could not save order",
                    ex);
            }

            // This line runs only if validation and saving succeed.
            Console.WriteLine($"Order total: ${total:F2}");
        }
        catch (MissingFieldException ex)
        {
            // Most specific exception is caught first.
            Console.WriteLine($"Missing field: {ex.FieldName}");
        }
        catch (InvalidQuantityException ex)
        {
            // Second specific exception is caught next.
            Console.WriteLine(
                $"Invalid quantity for field: {ex.FieldName}");
        }
        catch (OrderValidationException ex)
        {
            // General OrderValidationException is caught last.
            if (ex.InnerException != null)
            {
                Console.WriteLine(
                    $"Order validation failed: {ex.Message} " +
                    $"(caused by: {ex.InnerException.Message})");
            }
            else
            {
                Console.WriteLine(
                    $"Order validation failed: {ex.Message}");
            }
        }
        finally
        {
            // finally always executes whether an exception occurs or not.
            Console.WriteLine("Order attempt complete.");
        }
    }
}