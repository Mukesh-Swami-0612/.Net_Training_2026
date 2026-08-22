using System.Collections.Generic;
using System.Linq;

namespace Lab5_OrderByThenBy
{
    // Contains different LINQ sorting operations for products.
    public static class ProductSorter
    {
        // Sorts products by category ascending,
        // then sorts the price descending within each category.
        public static IEnumerable<Product> SortByCategoryAndPrice(
            List<Product> products)
        {
            return products
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.Price);
        }


        // Demonstrates the incorrect use of two OrderBy calls.
        public static IEnumerable<Product> BuggySort(
            List<Product> products)
        {
            return products
                .OrderBy(p => p.Category)
                .OrderBy(p => p.Price);
        }


        // Correctly sorts products by category,
        // then by price using ThenByDescending.
        public static IEnumerable<Product> FixedSort(
            List<Product> products)
        {
            return products
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.Price);
        }


        // Sorts products using three sorting keys:
        // 1. In-stock products first.
        // 2. Category ascending.
        // 3. Name ascending.
        public static IEnumerable<Product> SortByThreeKeys(
            List<Product> products)
        {
            return products
                .OrderByDescending(p => p.InStock)
                .ThenBy(p => p.Category)
                .ThenBy(p => p.Name);
        }
    }
}