using System;

namespace Lab6Generics
{
    // Summary: Represents a product and allows products to be compared by price.
    public class Product : IComparable<Product>
    {
        // Store the product name.
        public string Name { get; set; }

        // Store the product price.
        public double Price { get; set; }

        // Summary: Initializes a Product object with name and price.
        public Product(string name, double price)
        {
            // Assign the product name.
            Name = name;

            // Assign the product price.
            Price = price;
        }

        // Summary: Compares two products based on their prices.
        public int CompareTo(Product other)
        {
            // Handle a null product.
            if (other == null)
            {
                return 1;
            }

            // Compare the current product price with the other product price.
            return Price.CompareTo(other.Price);
        }

        // Summary: Returns product details in readable text format.
        public override string ToString()
        {
            // Return the product name and price.
            return $"{Name} - ₹{Price}";
        }
    }
}