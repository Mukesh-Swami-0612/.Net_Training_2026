namespace Lab6LambdaExpressions
{
    // OrderItem represents one product included in an order.
    public class OrderItem
    {
        // Name of the product.
        public string ProductName { get; set; }

        // Price of one unit.
        public double UnitPrice { get; set; }

        // Number of units purchased.
        public int Quantity { get; set; }

        // Constructor used to create an OrderItem.
        public OrderItem(string productName, double unitPrice, int quantity)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        // Calculates the total price for this item.
        public double GetTotal()
        {
            return UnitPrice * Quantity;
        }
    }
}