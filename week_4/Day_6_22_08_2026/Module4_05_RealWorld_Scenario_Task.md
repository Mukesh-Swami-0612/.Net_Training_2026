# C# Programming — LINQ
## Complex Real-Time Scenario Task (Assessed)

**Time allotted:** 120 minutes
**Mode:** Individual or pair programming
**Deliverable:** A console application project implementing everything below, plus a short README explaining key design decisions.

---

## Scenario: "InsightDesk" — Real-Time Retail Sales Analytics Query Engine

**InsightDesk** is the reporting core for a retail chain's back office. Store managers need fast, flexible answers over the day's sales data — top categories, best sellers, low performers, staff performance — all without writing new code for every question. This is exactly what LINQ is for: composing operators to answer varied questions over the same in-memory dataset.

---

## Functional Requirements

### 1. Domain Model

```csharp
public class SaleLineItem
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public string StaffName { get; set; }
    public string StoreLocation { get; set; }
    public DateTime SoldAt { get; set; }
    public decimal LineTotal => UnitPrice * Quantity;
}
```

Also model a small **promotions** hierarchy to exercise `OfType<T>`:

```csharp
public abstract class Promotion { public string Code { get; set; } }
public class PercentOffPromotion : Promotion { public double PercentOff { get; set; } }
public class FlatAmountPromotion : Promotion { public decimal AmountOff { get; set; } }
public class BuyOneGetOnePromotion : Promotion { }
```

Seed at least **40 sale line items** across at least 4 categories, 3 staff members, 2 store locations, and a spread of dates/times across a single simulated business day. Seed at least 6 promotions of mixed types (mix of all three subclasses).

### 2. Core Query Requirements (each is its own named method)

Implement each of the following as a separate method returning a clearly-typed result. **Alternate between query syntax and method syntax across the methods** — at least 3 of the 8 must use query syntax, at least 3 must use method syntax, and note in your README which is which and why you chose that form for that particular query.

1. `TopSellingProducts(int topN)` — top N products by total quantity sold, descending.
2. `RevenueByCategory()` — total revenue per category, descending by revenue, using `GroupBy` + `into` (query syntax) or the method-syntax equivalent.
3. `StaffPerformanceReport()` — per staff member: total sales count, total revenue, average sale value — sorted by total revenue descending, with a **secondary sort** by staff name ascending for ties (`OrderBy`/`ThenBy`).
4. `HourlySalesTrend()` — group sales by the hour of `SoldAt`, ordered chronologically, showing count and revenue per hour.
5. `PercentOffPromotionsOver(double minPercent)` — using `OfType<PercentOffPromotion>()`, return only percent-off promotions above a threshold.
6. `LowPerformingCategories(decimal revenueThreshold)` — categories whose total revenue is below the threshold, using `GroupBy` + `into` + `where` (query continuation).
7. `StoreComparisonReport()` — per store location: revenue, item count, and top category by revenue at that location (nested grouping/aggregation).
8. `DeferredVsSnapshotDemo()` — a method that visibly demonstrates deferred execution using the live sales list (build a query, mutate the list, show the deferred query reflects it) vs. an immediately-materialized snapshot that does not — printed console proof, not just a comment.

### 3. Query Syntax vs. Method Syntax Equivalence Check

- Pick any ONE of the 8 queries above and implement it a SECOND way (the syntax form you didn't use originally). Assert/print that both versions produce identical results (`SequenceEqual` or manual comparison).

### 4. `OrderBy`/`ThenBy` Correctness Check

- Deliberately include a broken version of `StaffPerformanceReport()`'s sort using `.OrderBy(...).OrderBy(...)` in a separate demonstration method `BrokenStaffSort()`, print its (wrong) output, and print the corrected output side by side with a one-line explanation.

### 5. Deferred Execution Safety

- `HourlySalesTrend()` and `RevenueByCategory()` must each be called, have their **returned query stored in a variable**, and only enumerated/printed after at least one additional operation happens in between (e.g., another report runs first) — demonstrate in your `Main` that this still works correctly, and explain in your README whether each of your 8 methods returns a deferred query or a materialized list, and why that choice was made for that specific method.

---

## Non-Functional / Code Quality Requirements

- No unhandled exceptions on any documented edge case (an empty promotions list for a given type, a store/category with zero sales, `topN` larger than the available product count).
- Prefer LINQ operators over manual loops throughout — hand-written `foreach` should only appear for **printing** results, not for filtering/sorting/grouping/aggregating them.
- XML doc comments on all public methods explaining what each report answers.
- Use `OfType<T>()` correctly (not `Cast<T>()` or manual `is`-checking loops) for the promotions filtering requirement.

---

## Demonstration Script (Console `Main`)

1. Seed the sale line items and promotions.
2. Call and print all 8 core query methods, clearly labeled with headers.
3. Run the syntax-equivalence check from §3 and print the confirmation.
4. Run `BrokenStaffSort()` beside the correct `StaffPerformanceReport()` and print both, with the one-line explanation.
5. Run `DeferredVsSnapshotDemo()` showing the live-mutation and snapshot behaviors explicitly.
6. Attempt at least one deliberate edge case (e.g., `TopSellingProducts(100)` when fewer than 100 products exist, or `PercentOffPromotionsOver(999)` matching nothing) and show it degrades gracefully (empty/partial result, no exception).

---

## Evaluation Rubric

| Criterion | Weight |
|---|---|
| Correctness of all 8 core query methods | 30% |
| Appropriate, justified mix of query syntax and method syntax | 15% |
| Correct `OfType<T>` usage for promotions filtering | 10% |
| `OrderBy`/`ThenBy` correctness, broken-vs-fixed demonstration | 15% |
| Deferred execution understanding demonstrated correctly | 15% |
| Code quality: LINQ-first (no manual filter/sort/group loops), XML docs, graceful edge cases | 15% |

---

## Stretch Goals (Optional, Bonus)

- Add a `Func<SaleLineItem, bool>[] filters` "ad-hoc query builder" — a method that accepts an array of predicates and ANDs them all together via `Aggregate` or successive `.Where()` calls, letting a caller compose an arbitrary filter at runtime.
- Simulate an `IQueryable<T>` scenario: wrap the sale list with `.AsQueryable()`, build a query, and in your README discuss what would need to change if this were actually backed by Entity Framework instead of an in-memory list (which operators might fail to translate, etc.).
- Add a `SelectMany`-based report: if each `SaleLineItem` optionally carries a `List<string> AppliedPromotionCodes`, produce a flattened "promotion usage count" report across all sales.

A full reference solution is provided in `Module4_06_RealWorld_Scenario_Solution.cs` for trainer use after the assessed session.
