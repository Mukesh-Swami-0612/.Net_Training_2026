namespace Lab8_ComprehensiveMiniReport
{
    // Represents the summary information for one product category.
    public class CategorySummary
    {
        // Stores the category name.
        public string Category { get; set; }

        // Stores the number of in-stock products in the category.
        public int ItemCount { get; set; }

        // Stores the total price of the in-stock products.
        public decimal TotalValue { get; set; }

        // Stores the name of the most expensive in-stock product.
        public string TopProduct { get; set; }
    }
}