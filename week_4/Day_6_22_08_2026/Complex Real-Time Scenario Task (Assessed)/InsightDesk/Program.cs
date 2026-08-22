using InsightDesk.Data;
using InsightDesk.Reports;
using InsightDesk.Services;

namespace InsightDesk;

public class Program
{
    public static void Main()
    {
         
        // 1. SEED DATA
         
        var sales = SeedData.CreateSales();
        var promotions = SeedData.CreatePromotions();

        var analytics = new SalesAnalyticsEngine(
            sales,
            promotions);

        Console.WriteLine("INSIGHTDESK ANALYTICS");         
        Console.WriteLine($"Sales seeded       : {sales.Count}");
        Console.WriteLine($"Promotions seeded  : {promotions.Count}");

         
        // 2. TOP SELLING PRODUCTS
        PrintHeader("1. TOP SELLING PRODUCTS");

        var topProducts = analytics.TopSellingProducts(5);

        foreach (var product in topProducts)
        {
            Console.WriteLine(
                $"{product.ProductName,-20} Quantity: {product.TotalQuantity}");
        }

         
        // 3. REVENUE BY CATEGORY
        PrintHeader("2. REVENUE BY CATEGORY");

        // The query is intentionally stored before enumeration.
        var revenueByCategory = analytics.RevenueByCategory();

        Console.WriteLine(
            "Revenue query created but not enumerated yet.");

        // Additional operation before enumeration.
        var staffBeforeRevenue = analytics.StaffPerformanceReport();

         
        Console.WriteLine("Staff report executed before category query:");
        foreach (var staff in staffBeforeRevenue)
        {
            Console.WriteLine(
                $"{staff.StaffName,-10} Revenue: {staff.TotalRevenue:C}");
        }

         
        Console.WriteLine("Now enumerating RevenueByCategory:");
        foreach (var category in revenueByCategory)
        {
            Console.WriteLine(
                $"{category.Category,-20} Revenue: {category.Revenue:C}");
        }

         
        // 4. STAFF PERFORMANCE
        PrintHeader("3. STAFF PERFORMANCE");
        var staffReport = analytics.StaffPerformanceReport();
        foreach (var staff in staffReport)
        {
            Console.WriteLine(
                $"{staff.StaffName,-10} " +
                $"Sales: {staff.SalesCount,-3} " +
                $"Revenue: {staff.TotalRevenue,15:C} " +
                $"Average: {staff.AverageSaleValue,15:C}");
        }

         
        // 5. HOURLY SALES TREND
        PrintHeader("4. HOURLY SALES TREND");
        // Query is stored first.
        var hourlyTrend = analytics.HourlySalesTrend();
        Console.WriteLine(
            "Hourly query created but not enumerated yet.");
        // Additional operation occurs before enumeration.
        var topProductCheck = analytics.TopSellingProducts(3);
        Console.WriteLine("Top products calculated before hourly query:");
        foreach (var product in topProductCheck)
        {
            Console.WriteLine(
                $"{product.ProductName,-20} {product.TotalQuantity}");
        }

         
        Console.WriteLine("Now enumerating HourlySalesTrend:");
        foreach (var hour in hourlyTrend)
        {
            Console.WriteLine(
                $"{hour.Hour:00}:00 - " +
                $"Sales: {hour.SalesCount,-3} " +
                $"Revenue: {hour.Revenue:C}");
        }

         
        // 6. PERCENT-OFF PROMOTIONS
        PrintHeader("5. PERCENT-OFF PROMOTIONS OVER 10%");
        var promotionsOver10 =
            analytics.PercentOffPromotionsOver(10);

        foreach (var promotion in promotionsOver10)
        {
            Console.WriteLine(
                $"{promotion.Code,-15} {promotion.PercentOff}% OFF");
        }

         
        // 7. LOW PERFORMING CATEGORIES
        PrintHeader("6. LOW PERFORMING CATEGORIES");
        var lowCategories =
            analytics.LowPerformingCategories(10000);

        foreach (var category in lowCategories)
        {
            Console.WriteLine(
                $"{category.Category,-20} Revenue: {category.Revenue:C}");
        }

         
        // 8. STORE COMPARISON
        PrintHeader("7. STORE COMPARISON");
        var storeReports =
            analytics.StoreComparisonReport();
        foreach (var store in storeReports)
        {
            Console.WriteLine(
                $"{store.StoreLocation,-10} " +
                $"Revenue: {store.Revenue,15:C} | " +
                $"Items: {store.ItemCount,-4} | " +
                $"Top Category: {store.TopCategory,-15} | " +
                $"Category Revenue: {store.TopCategoryRevenue:C}");
        }

         
        // 9. DEFERRED VS SNAPSHOT
        PrintHeader("8. DEFERRED VS SNAPSHOT");
        analytics.DeferredVsSnapshotDemo();
        // 10. QUERY SYNTAX VS METHOD SYNTAX
        PrintHeader("QUERY SYNTAX VS METHOD SYNTAX CHECK");
        analytics.SyntaxEquivalenceCheck();
        // 11. BROKEN VS CORRECT STAFF SORT
        PrintHeader("BROKEN VS CORRECT STAFF SORT");
        analytics.BrokenStaffSort();
        // 12. EDGE CASES
        PrintHeader("EDGE CASE DEMONSTRATIONS");
        Console.WriteLine("TopSellingProducts(100):");
        var manyProducts =
            analytics.TopSellingProducts(100).ToList();
        foreach (var product in manyProducts)
        {
            Console.WriteLine(
                $"{product.ProductName,-20} {product.TotalQuantity}");
        }

        Console.WriteLine(
            $"Returned {manyProducts.Count} products without throwing an exception.");
        Console.WriteLine("PercentOffPromotionsOver(999):");
        var impossiblePromotions =
            analytics.PercentOffPromotionsOver(999).ToList();
        if (impossiblePromotions.Count == 0)
        {
            Console.WriteLine("No promotions matched. Empty result handled safely.");
        }
        else
        {
            foreach (var promotion in impossiblePromotions)
            {
                Console.WriteLine(
                    $"{promotion.Code} - {promotion.PercentOff}%");
            }
        }

         
        Console.WriteLine("TopSellingProducts(0):");
        var zeroProducts =
            analytics.TopSellingProducts(0).ToList();
        Console.WriteLine(
            $"Returned {zeroProducts.Count} products without throwing an exception.");

        Console.WriteLine("DEMONSTRATION COMPLETE");
         
    }

    /// <summary>
    /// Prints a visual section header for console demonstrations.
    /// </summary>
    private static void PrintHeader(string title)
    {
        Console.WriteLine(title);
        Console.WriteLine(new string('=', title.Length));
    }
}