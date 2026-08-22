using InsightDesk.Models;

namespace InsightDesk.Data;

/// <summary>
/// Provides deterministic sample data for the InsightDesk application.
/// </summary>
public static class SeedData
{
    /// <summary>
    /// Creates the sample sale line items used by the demonstrations.
    /// </summary>
    public static List<SaleLineItem> CreateSales()
    {
        var day = new DateTime(2026, 8, 22);

        return new List<SaleLineItem>
        {
            new() { Id = 1, ProductName = "Laptop", Category = "Electronics", UnitPrice = 75000, Quantity = 2, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(9).AddMinutes(5) },
            new() { Id = 2, ProductName = "Mouse", Category = "Electronics", UnitPrice = 1200, Quantity = 5, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(9).AddMinutes(20) },
            new() { Id = 3, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 2500, Quantity = 3, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(9).AddMinutes(35) },
            new() { Id = 4, ProductName = "Monitor", Category = "Electronics", UnitPrice = 18000, Quantity = 2, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(10).AddMinutes(10) },
            new() { Id = 5, ProductName = "USB Cable", Category = "Electronics", UnitPrice = 500, Quantity = 8, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(10).AddMinutes(25) },

            new() { Id = 6, ProductName = "T-Shirt", Category = "Clothing", UnitPrice = 999, Quantity = 4, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(10).AddMinutes(40) },
            new() { Id = 7, ProductName = "Jeans", Category = "Clothing", UnitPrice = 2200, Quantity = 3, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(11).AddMinutes(5) },
            new() { Id = 8, ProductName = "Jacket", Category = "Clothing", UnitPrice = 3500, Quantity = 2, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(11).AddMinutes(20) },
            new() { Id = 9, ProductName = "Shoes", Category = "Clothing", UnitPrice = 4200, Quantity = 3, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(11).AddMinutes(45) },
            new() { Id = 10, ProductName = "Cap", Category = "Clothing", UnitPrice = 700, Quantity = 6, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(12).AddMinutes(5) },

            new() { Id = 11, ProductName = "Rice", Category = "Groceries", UnitPrice = 900, Quantity = 5, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(12).AddMinutes(15) },
            new() { Id = 12, ProductName = "Wheat Flour", Category = "Groceries", UnitPrice = 600, Quantity = 4, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(12).AddMinutes(30) },
            new() { Id = 13, ProductName = "Cooking Oil", Category = "Groceries", UnitPrice = 1600, Quantity = 3, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(12).AddMinutes(45) },
            new() { Id = 14, ProductName = "Sugar", Category = "Groceries", UnitPrice = 500, Quantity = 7, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(13).AddMinutes(5) },
            new() { Id = 15, ProductName = "Tea", Category = "Groceries", UnitPrice = 450, Quantity = 9, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(13).AddMinutes(20) },

            new() { Id = 16, ProductName = "Shampoo", Category = "Personal Care", UnitPrice = 450, Quantity = 6, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(13).AddMinutes(40) },
            new() { Id = 17, ProductName = "Soap", Category = "Personal Care", UnitPrice = 80, Quantity = 12, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(14).AddMinutes(5) },
            new() { Id = 18, ProductName = "Toothpaste", Category = "Personal Care", UnitPrice = 180, Quantity = 8, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(14).AddMinutes(20) },
            new() { Id = 19, ProductName = "Face Wash", Category = "Personal Care", UnitPrice = 350, Quantity = 5, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(14).AddMinutes(40) },
            new() { Id = 20, ProductName = "Hand Wash", Category = "Personal Care", UnitPrice = 220, Quantity = 7, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(15).AddMinutes(5) },

            new() { Id = 21, ProductName = "Laptop", Category = "Electronics", UnitPrice = 75000, Quantity = 1, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(15).AddMinutes(20) },
            new() { Id = 22, ProductName = "Mouse", Category = "Electronics", UnitPrice = 1200, Quantity = 7, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(15).AddMinutes(40) },
            new() { Id = 23, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 2500, Quantity = 4, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(16).AddMinutes(5) },
            new() { Id = 24, ProductName = "Monitor", Category = "Electronics", UnitPrice = 18000, Quantity = 1, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(16).AddMinutes(20) },
            new() { Id = 25, ProductName = "USB Cable", Category = "Electronics", UnitPrice = 500, Quantity = 10, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(16).AddMinutes(45) },

            new() { Id = 26, ProductName = "T-Shirt", Category = "Clothing", UnitPrice = 999, Quantity = 5, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(17).AddMinutes(5) },
            new() { Id = 27, ProductName = "Jeans", Category = "Clothing", UnitPrice = 2200, Quantity = 2, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(17).AddMinutes(20) },
            new() { Id = 28, ProductName = "Jacket", Category = "Clothing", UnitPrice = 3500, Quantity = 3, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(17).AddMinutes(40) },
            new() { Id = 29, ProductName = "Shoes", Category = "Clothing", UnitPrice = 4200, Quantity = 2, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(18).AddMinutes(5) },
            new() { Id = 30, ProductName = "Cap", Category = "Clothing", UnitPrice = 700, Quantity = 8, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(18).AddMinutes(20) },

            new() { Id = 31, ProductName = "Rice", Category = "Groceries", UnitPrice = 900, Quantity = 4, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(18).AddMinutes(40) },
            new() { Id = 32, ProductName = "Wheat Flour", Category = "Groceries", UnitPrice = 600, Quantity = 5, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(19).AddMinutes(5) },
            new() { Id = 33, ProductName = "Cooking Oil", Category = "Groceries", UnitPrice = 1600, Quantity = 2, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(19).AddMinutes(20) },
            new() { Id = 34, ProductName = "Sugar", Category = "Groceries", UnitPrice = 500, Quantity = 6, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(19).AddMinutes(40) },
            new() { Id = 35, ProductName = "Tea", Category = "Groceries", UnitPrice = 450, Quantity = 8, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(20).AddMinutes(5) },

            new() { Id = 36, ProductName = "Shampoo", Category = "Personal Care", UnitPrice = 450, Quantity = 5, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(20).AddMinutes(20) },
            new() { Id = 37, ProductName = "Soap", Category = "Personal Care", UnitPrice = 80, Quantity = 15, StaffName = "Amit", StoreLocation = "Gurgaon", SoldAt = day.AddHours(20).AddMinutes(40) },
            new() { Id = 38, ProductName = "Toothpaste", Category = "Personal Care", UnitPrice = 180, Quantity = 10, StaffName = "Priya", StoreLocation = "Delhi", SoldAt = day.AddHours(21).AddMinutes(5) },
            new() { Id = 39, ProductName = "Face Wash", Category = "Personal Care", UnitPrice = 350, Quantity = 4, StaffName = "Rahul", StoreLocation = "Gurgaon", SoldAt = day.AddHours(21).AddMinutes(20) },
            new() { Id = 40, ProductName = "Hand Wash", Category = "Personal Care", UnitPrice = 220, Quantity = 9, StaffName = "Amit", StoreLocation = "Delhi", SoldAt = day.AddHours(21).AddMinutes(40) },

            new() { Id = 41, ProductName = "Laptop", Category = "Electronics", UnitPrice = 75000, Quantity = 1, StaffName = "Priya", StoreLocation = "Gurgaon", SoldAt = day.AddHours(22).AddMinutes(5) },
            new() { Id = 42, ProductName = "Mouse", Category = "Electronics", UnitPrice = 1200, Quantity = 9, StaffName = "Rahul", StoreLocation = "Delhi", SoldAt = day.AddHours(22).AddMinutes(20) }
        };
    }

    /// <summary>
    /// Creates a mixed collection of promotions.
    /// </summary>
    public static List<Promotion> CreatePromotions()
    {
        return new List<Promotion>
        {
            new PercentOffPromotion { Code = "PERCENT10", PercentOff = 10 },
            new PercentOffPromotion { Code = "PERCENT15", PercentOff = 15 },
            new PercentOffPromotion { Code = "PERCENT25", PercentOff = 25 },
            new FlatAmountPromotion { Code = "FLAT500", AmountOff = 500 },
            new FlatAmountPromotion { Code = "FLAT1000", AmountOff = 1000 },
            new BuyOneGetOnePromotion { Code = "BOGO1" },
            new BuyOneGetOnePromotion { Code = "BOGO2" }
        };
    }
}