namespace Lab6LambdaExpressions
{
    // Product represents a product available in the store.
    public class Product
    {
        // Product name.
        public string Name { get; set; }

        // Product price.
        public double Price { get; set; }

        // Number of products currently in stock.
        public int Stock { get; set; }

        // Discount percentage.
        public double DiscountPercent { get; set; }

        // Constructor used to create a Product object.
        public Product(string name, double price, int stock, double discountPercent)
        {
            Name = name;
            Price = price;
            Stock = stock;
            DiscountPercent = discountPercent;
        }

        // Calculates the price after applying the discount.
        public double GetDiscountedPrice()
        {
            return Price - (Price * DiscountPercent / 100);
        }

        // Returns a formatted string representing the product.
        public override string ToString()
        {
            return $"{Name,-15} Price: {Price,8:F2}  Stock: {Stock,3}  " +
                   $"Discount: {DiscountPercent,5:F1}%  " +
                   $"Discounted: {GetDiscountedPrice(),8:F2}";
        }
    }
}