# C# Programming — Collections & Generics
## Lab Exercises

Complete each lab in order — later labs build on concepts from earlier ones. Solutions are in `04_Lab_Solutions.cs` (don't peek until you've tried!).

---

### Lab 1 — Non-Generic vs Generic Collections

**Goal:** Feel the pain of `System.Collections`, then fix it.

1. Create an `ArrayList` and add: `10`, `"twenty"`, `30.5`, `true`.
2. Write a loop that sums only the numeric-looking entries using `is` pattern matching and casting. Observe how easy it is to accidentally introduce a bug (e.g., someone adds a non-numeric object later).
3. Now redo the same task using `List<int>` — the compiler should refuse to let you add `"twenty"`.
4. Using `System.Diagnostics.Stopwatch`, benchmark inserting 2,000,000 integers into an `ArrayList` vs a `List<int>`. Print both timings.

**Deliverable:** Console app printing the sum, a compile-error screenshot/comment explaining why step 3 rejects bad input, and the benchmark timings.

---

### Lab 2 — `List<T>` CRUD + Sorting

Build a small **Student Roster** manager.

1. Define a `Student` class: `Id (int)`, `Name (string)`, `Marks (double)`.
2. Store students in a `List<Student>`.
3. Implement:
   - `AddStudent(Student s)`
   - `RemoveStudent(int id)`
   - `UpdateMarks(int id, double newMarks)`
   - `GetTopStudent()` — returns the student with highest marks
4. Implement custom sorting two ways:
   - `list.Sort(...)` using a lambda `Comparison<Student>`
   - A separate `IComparer<Student>` class `ByNameComparer`
5. Print the roster sorted by marks (descending) and then by name (ascending).

**Deliverable:** Console app demonstrating all operations with clear printed output before/after each step.

---

### Lab 3 — `Dictionary<K,V>` Inventory Lookup

Build an **Inventory Lookup System**.

1. Use `Dictionary<string, int>` where key = SKU code, value = quantity on hand.
2. Load at least 8 sample SKUs.
3. Implement:
   - `RestockItem(sku, quantity)` — adds to existing quantity, or inserts if new (use `TryGetValue`/indexer — no unnecessary `ContainsKey` + indexer double-lookup).
   - `SellItem(sku, quantity)` — throws a custom exception `InsufficientStockException` if not enough stock.
   - `LowStockReport(int threshold)` — returns all SKUs with quantity below threshold, using an iteration technique appropriate for `Dictionary<K,V>`.
4. Handle the "key not found" case gracefully everywhere (no unhandled `KeyNotFoundException`).

**Deliverable:** Console app; demonstrate a successful restock, a successful sale, an attempted oversell (exception caught and reported), and a low-stock report.

---

### Lab 4 — `Stack<T>` and `Queue<T>` in Action

Build **two** small simulations:

**4A — Balanced Parentheses Checker (Stack)**
Write `bool IsBalanced(string expression)` that checks whether `(`, `{`, `[` are correctly matched/nested in a string like `"{[a+(b*c)]-d}"`. Use `Stack<char>`.

**4B — Print Job Queue (Queue)**
Simulate a printer queue:
1. `PrintJob { string DocumentName; int Pages; }`
2. Enqueue 5 print jobs.
3. Process jobs one at a time with `Dequeue()`, printing "Printing X (Y pages)..." with a `Peek()` before each dequeue to show "Now printing next: ...".
4. Add a "priority interrupt" feature: if a high-priority job arrives, it should be processed before non-priority jobs already queued (hint: you'll need to think about whether `Queue<T>` alone is sufficient, or whether you need two queues / a different structure — justify your choice in a code comment).

**Deliverable:** Console app with both simulations and sample runs shown in output/comments.

---

### Lab 5 — `HashSet<T>` Set Operations

Build a **Customer Overlap Analyzer** for a marketing team.

1. Two `HashSet<string>` of customer emails: `NewsletterSubscribers` and `AppUsers`.
2. Compute and print:
   - Customers who are **both** subscribers and app users (`IntersectWith`)
   - Customers who are subscribers but **not** app users (`ExceptWith`)
   - All unique customers across both lists (`UnionWith`)
   - Whether `NewsletterSubscribers` is a subset of `AppUsers` (`IsSubsetOf`)
3. Deduplicate a `List<string>` of 100 randomly generated emails (with intentional duplicates) into a `HashSet<string>` and report how many duplicates were removed.

**Deliverable:** Console app printing each computed set clearly labeled.

---

### Lab 6 — Generics: Class, Method, and Constraints

1. Write a generic method:
   ```csharp
   public static void Swap<T>(ref T a, ref T b)
   ```
2. Write a generic class `Pair<TFirst, TSecond>` with `First`, `Second` properties, a constructor, and an overridden `ToString()`.
3. Write a generic class `MinMaxTracker<T> where T : IComparable<T>` that:
   - Has an `Add(T value)` method
   - Tracks and exposes `Min` and `Max` properties in O(1) per add (don't rescan the whole collection each time)
4. Write a generic method `bool AllMatch<T>(IEnumerable<T> items, Func<T, bool> predicate)` that returns true only if every item satisfies the predicate.
5. Test all four with at least two different type arguments each (e.g., `int` and a custom `Product` class implementing `IComparable<Product>` by price).

**Deliverable:** Console app exercising each generic construct with printed proof of correctness.

---

### Lab 7 — Build Your Own Generic Collection

1. Implement a generic `FixedSizeStack<T>` class that:
   - Has a fixed capacity set in the constructor
   - Throws `InvalidOperationException` on `Push` when full, and on `Pop`/`Peek` when empty
   - Implements `IEnumerable<T>` so it can be used in `foreach` (iterate top-to-bottom)
2. Implement `IReadOnlyCollection<T>` on the same class (expose `Count`).
3. Write a generic extension method:
   ```csharp
   public static FixedSizeStack<T> ToFixedSizeStack<T>(this IEnumerable<T> source, int capacity)
   ```
4. Demonstrate: build a stack of `int`, iterate it with `foreach`, and convert a `List<string>` into a `FixedSizeStack<string>` using your extension method.

**Deliverable:** Console app + the `FixedSizeStack<T>` class in its own file, demonstrating all requirements including the exception cases (caught and printed, not crashing the app).

---

## Submission Checklist

- [ ] Code compiles with zero warnings
- [ ] Each lab's `Main`/entry point clearly labeled (e.g., menu or separate methods called in sequence)
- [ ] Exceptions are handled, not left to crash the program
- [ ] Chosen collection type for each task is justified in a comment where the guide discusses trade-offs (Labs 3, 4B, 5, 7)
- [ ] No use of `ArrayList`/`Hashtable`/non-generic collections outside Lab 1
