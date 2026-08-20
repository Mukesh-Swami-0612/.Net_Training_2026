using System;

namespace InventoryLookup
{
    // Summary:
    // InsufficientStockException is a custom exception used
    // when an SKU is missing or there is not enough stock.
    public class InsufficientStockException : Exception
    {
        // Summary:
        // Constructor receives the error message and passes it
        // to the parent Exception class.
        public InsufficientStockException(string message)
            : base(message)
        {
        }
    }
}