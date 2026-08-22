# C# Programming — LINQ
## Lab Exercises

Complete each lab in order. Solutions are in `Module4_04_Lab_Solutions.cs` — attempt each lab fully before checking.

Use this shared dataset for every lab unless the lab says otherwise:

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }
}
```
Seed at least 12 products across 3–4 categories, with a mix of price points and stock status.

---

### Lab 1 — Query Syntax vs Method Syntax Equivalence

1. Write the same query FOUR times, proving they all produce identical results: "products under Rs.1000, ordered by name" —
   - (a) fully in method syntax
   - (b) fully in query syntax
   - (c) query syntax for the `where`, piped into a method-syntax `.OrderBy(...)`
   - (d) method-syntax `.Where(...)`, piped into a `select ... from` wrapped query-syntax `orderby` (hint: you'll need parentheses around the query-syntax portion)
2. Print all four results and confirm (via a comment or a `SequenceEqual` check) they match.

**Deliverable:** Console app demonstrating equivalence with printed proof.

---

### Lab 2 — `Select` Projections

1. Project the product list to just names (`IEnumerable<string>`).
2. Project to an anonymous type containing `Name` and a computed `PriceWithTax` (assume 18% tax).
3. Project to a named `ProductSummaryDto { string Name; string PriceLabel; }` class, where `PriceLabel` is a formatted string like `"Rs.999.00"`.
4. Use the index-aware `Select` overload to project each product into `"#1: Keyboard"`-style strings.

**Deliverable:** Console app printing all four projection results.

---

### Lab 3 — `Where` Filtering

1. Filter products under Rs.500.
2. Filter products that are BOTH in a specific category AND in stock.
3. Filter using the index-aware `Where` overload to get only products at even positions in the original list.
4. Chain two separate `.Where()` calls vs. one `.Where()` with `&&` — confirm they produce identical results (they should — LINQ composes predicates this way commonly for optional/conditional filters).

**Deliverable:** Console app printing all four filtered results with counts.

---

### Lab 4 — `OfType<T>`

1. Create a `List<object>` mixing `int`, `string`, `double`, and `Product` instances. Use `OfType<int>()`, then `OfType<string>()`, then `OfType<Product>()` to extract each subset.
2. Model a small shape hierarchy: `Shape` (base), `Circle : Shape { double Radius }`, `Rectangle : Shape { double Width, Height }`. Build a `List<Shape>` containing a mix of both. Use `OfType<Circle>()` to compute total circle area, and `OfType<Rectangle>()` to compute total rectangle area.
3. Demonstrate the difference between `OfType<Rectangle>()` and `Cast<Rectangle>()` on the same mixed list — show `Cast<Rectangle>()` throwing `InvalidCastException` when the list contains a `Circle`, caught and reported (not crashing the app).

**Deliverable:** Console app demonstrating all three, including the caught `Cast<T>` exception.

---

### Lab 5 — `OrderBy` / `ThenBy`

1. Sort products by `Category` ascending, then by `Price` descending within each category (`OrderBy` + `ThenByDescending`).
2. Deliberately write the "bug" version using `.OrderBy(p => p.Category).OrderBy(p => p.Price)` and print the result — in a comment, explain why the category ordering is lost.
3. Fix it with `ThenBy` and print the corrected result for comparison.
4. Sort with 3 keys: `InStock` (in-stock first), then `Category` ascending, then `Name` ascending.

**Deliverable:** Console app showing the buggy vs. fixed multi-key sort side by side, plus the 3-key sort.

---

### Lab 6 — `GroupBy` and `into`

1. Group products by `Category`; for each group print the category name and the count of products in it.
2. Using query syntax with `into`, group by `Category`, keep only categories with 3 or more products, and order the remaining groups by total inventory value (`Sum(p => p.Price)`) descending.
3. For each category group, compute and print: count, total value, average price, and the single most expensive product's name (all via chained aggregation methods on the group).
4. Group by a composite key: `(Category, InStock)` — print each group's key and count.

**Deliverable:** Console app printing all four grouped reports clearly labeled.

---

### Lab 7 — Deferred vs. Immediate Execution

1. Build a `Where` query (deferred) over a `List<Product>`, print a "query built" message, then add a new product to the underlying list that matches the filter, THEN enumerate the query and show the new product appears.
2. Repeat the same experiment but call `.ToList()` immediately after building the query — add a new matching product afterward — and show the snapshot does NOT include the new product.
3. Build a query that has an expensive-looking (simulated with a `Console.WriteLine` inside the predicate) `Where` clause, and enumerate it TWICE with two separate `foreach` loops — show (via the printed side-effects) that the predicate runs again on the second enumeration, then fix it by materializing once with `.ToList()` and reusing that list for both loops.

**Deliverable:** Console app with clear before/after output demonstrating deferred execution, snapshotting, and the double-enumeration cost + fix.

---

### Lab 8 — Comprehensive Mini Report

Using the product dataset, produce a single console report combining everything from this module:

1. Filter to in-stock products only (`Where`).
2. Group by `Category` (`GroupBy`).
3. Within each group, order products by price descending (`OrderByDescending` inside the group projection).
4. Order the categories themselves by total category value descending (`into` + `orderby`, or method-syntax equivalent).
5. Project each category group into a summary object with `Category`, `ItemCount`, `TotalValue`, and `TopProduct` (name of the most expensive item).
6. Print the final report, one section per category, in descending total-value order, using both a query-syntax version and a method-syntax version — confirm they match.

**Deliverable:** Console app producing a formatted, readable multi-category report, built two ways (query syntax and method syntax) with matching output.

---

## Submission Checklist

- [ ] Code compiles with zero warnings
- [ ] Each lab clearly labeled in output (menu or sequential method calls with headers)
- [ ] No unhandled exceptions — the `Cast<T>` failure in Lab 4 is caught and reported, not left to crash
- [ ] At least one query-syntax AND one method-syntax version of an equivalent query appears somewhere (Labs 1, 8)
- [ ] The `OrderBy`/`ThenBy` pitfall is demonstrated AND fixed (Lab 5)
- [ ] Deferred execution is demonstrated with both the "surprise" case and the `.ToList()` fix (Lab 7)
