# C# Programming — Tuples, Collection API, Generics & Iterators
## Lab Exercises

Complete each lab in order. Solutions are in `Module2_04_Lab_Solutions.cs` — attempt each lab fully before checking.

---

### Lab 1 — Tuples

1. Write `(double Average, double Min, double Max) GetStats(IEnumerable<double> values)` returning aggregate stats as a named `ValueTuple`.
2. Call it and use deconstruction to extract `avg`, `min`, `max` into separate variables.
3. Write `(bool Success, string? ErrorMessage) TryParseAge(string input)` that returns `(true, null)` on success or `(false, "reason")` on failure — a common pattern replacing exceptions for expected failure cases.
4. Build a `Dictionary<(int Row, int Col), string> board` representing a tic-tac-toe board. Populate a few cells and print the board by iterating `(row, col)` from `(0,0)` to `(2,2)`, looking up each cell (default to `"-"` if empty).

**Deliverable:** Console app demonstrating all four, with printed output proving correctness.

---

### Lab 2 — Scenario-Driven Collection Choice

For each scenario below, pick the correct collection (`HashSet<T>`, `Queue<T>`, `Stack<T>`, or `LinkedList<T>`), implement it, and justify your choice in a code comment.

1. **Undo stack for a text editor** — supports `RecordAction(string action)` and `Undo()` returning the most recent action, or `null` if none remain.
2. **Customer support ticket queue** — supports `SubmitTicket(string ticketId)` and `ProcessNext()` returning the oldest unprocessed ticket.
3. **Unique daily active user tracker** — supports `RecordVisit(int userId)` and `UniqueVisitorCount()`; must handle the same user visiting multiple times without double-counting.
4. **Music playlist with fast insert/remove at an arbitrary position** — supports `InsertAfter(string afterSong, string newSong)` and `Remove(string song)`.

**Deliverable:** Four small classes/methods, each with a short `Main`-driven demonstration and a one-line justification comment.

---

### Lab 3 — BFS and DFS

Given this graph (as a `Dictionary<string, List<string>>`):
```
A -> B, C
B -> D
C -> D
D -> E
```

1. Implement `BreadthFirstSearch(graph, "A")` using `Queue<string>` and `HashSet<string>` for visited-tracking.
2. Implement `DepthFirstSearch(graph, "A")` using `Stack<string>`.
3. Print both traversal orders and explain in a comment why they differ.

**Deliverable:** Console app printing both traversal results.

---

### Lab 4 — The Collection API

1. Write a generic method `T[] Snapshot<T>(ICollection<T> source)` that uses `CopyTo` (not a `foreach` loop) to copy the collection into a correctly-sized array.
2. Write `bool TryAddAll<T>(ICollection<T> target, IEnumerable<T> items)` that checks `target.IsReadOnly` first, returns `false` without modifying anything if read-only, otherwise adds all items and returns `true`.
3. Demonstrate both methods working identically against a `List<T>`, a `HashSet<T>`, and a `LinkedList<T>` — proving the methods don't care about the concrete implementation.
4. Attempt `TryAddAll` against `array.AsReadOnly()` or a similar read-only wrapper and show it correctly refuses.

**Deliverable:** Console app proving the "program to the interface" principle with at least 3 different concrete collection types.

---

### Lab 5 — Build `MyList<T>`

Implement a simplified generic dynamic array class:

```csharp
public class MyList<T> : IEnumerable<T>
```

Required members: `Add`, `RemoveAt`, indexer `this[int]` (get and set), `Count`, capacity doubling on growth, and a working `GetEnumerator()` (via `yield return`).

1. Test with `int` and with a custom reference type.
2. Prove `foreach` works on your class.
3. Prove collection-initializer syntax works: `new MyList<int> { 1, 2, 3 }`.
4. Deliberately trigger and catch an out-of-range access.

**Deliverable:** `MyList<T>` in its own class plus a demonstration `Main`.

---

### Lab 6 — Build `MyDictionary<TKey,TValue>`

Implement a simplified chained-hash-table generic dictionary:

```csharp
public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>> where TKey : notnull
```

Required members: `Add`/indexer set, `TryGetValue`, indexer get (throwing `KeyNotFoundException` if missing), and `GetEnumerator()`.

1. Test by storing at least 20 key/value pairs (enough to guarantee some hash collisions with a small bucket count) and verify every key still retrieves the correct value.
2. Compare lookup behavior against the real `Dictionary<TKey,TValue>` for the same data to confirm correctness.
3. Demonstrate collection-initializer-style construction using index initializer syntax (requires an indexer setter, which you already built).

**Deliverable:** `MyDictionary<TKey,TValue>` in its own class plus a demonstration `Main` including a correctness check against the built-in `Dictionary<K,V>`.

---

### Lab 7 — Generic Interface + Custom Add Overloads for Collection Initializers

1. Define `public interface IRepository<T> where T : class { void Add(T item); T? GetById(int id); IEnumerable<T> GetAll(); }`.
2. Implement `InMemoryRepository<T> : IRepository<T> where T : class, IEntity` backed by your `MyDictionary<int, T>` from Lab 6 (or `Dictionary<int,T>` if you prefer to isolate the concern).
3. Build a `TagList` class (as in the guide) implementing `IEnumerable<string>` with **two overloaded `Add` methods** — one taking a single string, one taking `(string tag, bool highlighted)`.
4. Demonstrate constructing a `TagList` using mixed collection-initializer syntax exercising both `Add` overloads.

**Deliverable:** Console app showing the repository storing/retrieving a custom entity, and the `TagList` built via initializer syntax.

---

### Lab 8 — Iterators

1. Write `IEnumerable<int> Fibonacci()` as an infinite iterator using `yield return`. Consume only the first 10 values with `.Take(10)`.
2. Write `IEnumerable<int> TakeWhilePositive(IEnumerable<int> source)` using `yield break` to stop at the first non-positive value.
3. Prove lazy evaluation: add a `Console.WriteLine` inside an iterator method, call the method, and show nothing prints until you actually `foreach` over the result.
4. Build a small `TreeNode<T> : IEnumerable<T>` class (as in the guide) with a recursive `yield return`-based `GetEnumerator()` performing depth-first traversal. Construct a tree with at least 2 levels and print the traversal via `foreach`.
5. Add a second named iterator method to any class from an earlier lab (e.g., `MyList<T>.InReverse()`) that yields elements in reverse order without allocating a second array.

**Deliverable:** Console app demonstrating all five, including printed proof of lazy evaluation ordering.

---

## Submission Checklist

- [ ] Code compiles with zero warnings
- [ ] Each lab clearly labeled in output (menu or sequential method calls with headers)
- [ ] No unhandled exceptions — deliberate failure cases are caught and reported
- [ ] Collection-choice justifications present as comments where required (Lab 2)
- [ ] Custom generic classes (`MyList<T>`, `MyDictionary<TKey,TValue>`) implement `IEnumerable<T>` correctly and support `foreach`
