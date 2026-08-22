namespace Lab1LinqEquivalence;

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 55000, InStock = true },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 700, InStock = true },
            new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 1200, InStock = true },
            new Product { Id = 4, Name = "Notebook", Category = "Stationery", Price = 150, InStock = true },
            new Product { Id = 5, Name = "Pen", Category = "Stationery", Price = 50, InStock = true },
            new Product { Id = 6, Name = "Backpack", Category = "Accessories", Price = 900, InStock = false },
            new Product { Id = 7, Name = "Water Bottle", Category = "Accessories", Price = 600, InStock = true },
            new Product { Id = 8, Name = "Headphones", Category = "Electronics", Price = 1800, InStock = true },
            new Product { Id = 9, Name = "Pencil", Category = "Stationery", Price = 30, InStock = true },
            new Product { Id = 10, Name = "Desk Lamp", Category = "Home", Price = 850, InStock = false },
            new Product { Id = 11, Name = "Chair", Category = "Home", Price = 2500, InStock = true },
            new Product { Id = 12, Name = "Table Clock", Category = "Home", Price = 950, InStock = true }
        };

        // Query A - Fully Method Syntax
        var queryA = products
            .Where(p => p.Price < 1000)
            .OrderBy(p => p.Name);

        // Query B - Fully Query Syntax
        var queryB =
            from p in products
            where p.Price < 1000
            orderby p.Name
            select p;

        // Query C - Query Syntax for WHERE + Method Syntax for ORDER BY
        var queryC =
            (from p in products
             where p.Price < 1000
             select p)
            .OrderBy(p => p.Name);

        // Query D - Method Syntax for WHERE + Query Syntax for ORDER BY
        var filteredProducts = products
            .Where(p => p.Price < 1000);

        var queryD =
            from p in filteredProducts
            orderby p.Name
            select p;

        // Display Results
        PrintResults("A - Fully Method Syntax", queryA);
        PrintResults("B - Fully Query Syntax", queryB);
        PrintResults("C - Query WHERE + Method OrderBy", queryC);
        PrintResults("D - Method Where + Query OrderBy", queryD);

        // Convert all results to List for comparison
        var resultA = queryA.ToList();
        var resultB = queryB.ToList();
        var resultC = queryC.ToList();
        var resultD = queryD.ToList();

        // Check whether all four results are identical
        bool allMatch =
            resultA.SequenceEqual(resultB) &&
            resultA.SequenceEqual(resultC) &&
            resultA.SequenceEqual(resultD);

        // Final comparison
        Console.WriteLine("EQUIVALENCE CHECK");

        Console.WriteLine(
            $"Query A == Query B: {resultA.SequenceEqual(resultB)}");

        Console.WriteLine(
            $"Query A == Query C: {resultA.SequenceEqual(resultC)}");

        Console.WriteLine(
            $"Query A == Query D: {resultA.SequenceEqual(resultD)}");

        if (allMatch)
        {
            Console.WriteLine(
                "SUCCESS: All four queries produce identical results.");
        }
        else
        {
            Console.WriteLine(
                "FAILED: The query results are different.");
        }
    }

    // Function to print products
    public static void PrintResults(
        string title,
        IEnumerable<Product> products)
    {
        Console.WriteLine(title);

        foreach (Product product in products)
        {
            Console.WriteLine(
                $"{product.Name,-15} " +
                $"₹{product.Price,-8} " +
                $"{product.Category,-15} " +
                $"In Stock: {product.InStock}");
        }
    }
}