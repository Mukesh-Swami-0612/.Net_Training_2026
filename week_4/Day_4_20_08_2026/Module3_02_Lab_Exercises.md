# C# Programming — Delegates & Lambda
## Lab Exercises

Complete each lab in order. Solutions are in `Module3_04_Lab_Solutions.cs` — attempt each lab fully before checking.

---

### Lab 1 — `var` vs Explicit Types vs `dynamic`

1. Declare the same value three ways: `var count = 10;`, `int countExplicit = 10;`, `dynamic countDynamic = 10;`. Print each and print `.GetType()` for all three.
2. Attempt `countDynamic = "now text";` followed by using it in an arithmetic expression (e.g., `countDynamic + 5`). Catch and print the resulting runtime exception.
3. Create an anonymous type `var point = new { X = 3, Y = 7 };` and print its properties. Try (and comment out) an assignment to `point.X` — note the compiler error in a comment.
4. Write a short paragraph (as a code comment) explaining when you'd choose `dynamic` over `var` in a real project — cite a scenario from the guide.

**Deliverable:** Console app demonstrating all three typing approaches with the runtime exception caught and reported, not crashing the app.

---

### Lab 2 — Declaring and Using Delegates

1. Declare a custom delegate `public delegate double Discount(double price);`.
2. Write three matching methods: `NoDiscount`, `TenPercentOff`, `HalfOff`.
3. Write a method `ApplyDiscount(double price, Discount discount)` that invokes the passed delegate.
4. Call `ApplyDiscount` three times, once per discount method, printing the result each time.
5. Store all three methods in a `List<Discount>` and iterate the list, invoking each one against the same price, printing every result.

**Deliverable:** Console app showing delegate declaration, instantiation with different methods, and invocation via both direct calls and a list of delegates.

---

### Lab 3 — Multicast Delegates

1. Declare `public delegate void OrderEvent(string orderId);`.
2. Create three separate handler methods: `LogToConsole`, `SendEmailSimulation`, `UpdateInventorySimulation` (each just prints a distinguishing message).
3. Combine all three into one multicast delegate using `+=` and invoke it once — confirm all three run, in the order added.
4. Remove one handler with `-=` and invoke again — confirm only the remaining two run.
5. Demonstrate the "-= doesn't work across different lambda instances" pitfall: subscribe two *lambdas* with identical bodies, then try to unsubscribe one using a freshly-written (not stored) lambda — show it fails to remove anything, then fix it by storing the original delegate reference and successfully unsubscribing.

**Deliverable:** Console app clearly demonstrating multicast add/remove behavior and the reference-equality pitfall (both the failure and the fix).

---

### Lab 4 — `Func<>`, `Action<>`, `Predicate<T>`

1. Write a `Func<int, int, int>` for addition and one for multiplication (as lambdas, no custom delegate type).
2. Write an `Action<string>` that logs a message with a timestamp prefix.
3. Write a `Predicate<int>` (or `Func<int,bool>`) that checks if a number is prime; use it to filter a `List<int>` of 1–50 down to just the primes.
4. Write a generic method `void Repeat(int times, Action action)` that invokes `action` the given number of times; call it with a lambda that prints "Tick".

**Deliverable:** Console app exercising all four generic delegate types with printed proof of correctness.

---

### Lab 5 — Anonymous Methods + Closures

1. Using the `delegate` keyword (not a lambda), write an anonymous method assigned to an `Action<int>` that squares and prints its argument.
2. Write an anonymous method that captures and increments an outer `int total` variable each time it's called; call it 5 times and print `total` afterward to prove the closure mutated the outer variable.
3. Rewrite both anonymous methods as lambdas and confirm identical behavior — add a comment noting the syntactic difference.

**Deliverable:** Console app with both anonymous-method and lambda versions side by side, output proving closures work identically in both forms.

---

### Lab 6 — Lambda Expressions: Expression vs Statement Form

1. Write an expression-bodied lambda `Func<double, double, double> rectangleArea = (w, h) => w * h;`.
2. Write a statement-bodied lambda `Action<Order> printReceipt` that prints a multi-line formatted receipt (uses `{ }` with multiple statements).
3. Sort a `List<Product>` three different ways using lambda-based `Comparison<T>`/`Sort` overloads: by price ascending, by name descending, by a computed "discounted price" value.
4. Use `List<T>.RemoveAll(Predicate<T>)` with a lambda to remove all out-of-stock products from a list.

**Deliverable:** Console app demonstrating all four, printing before/after state for the sort and removal steps.

---

### Lab 7 — The Loop-Variable Capture Pitfall

1. Write a `for` loop that creates 3 `Action` delegates, each intended to print its loop index, WITHOUT copying the index into a local variable first. Store them in a `List<Action>`, invoke all three after the loop, and observe (and explain in a comment) the actual output.
2. Fix it by copying the loop variable into a local variable inside the loop body before capturing it in the lambda. Show the corrected output.
3. Do the same experiment with a `foreach` loop instead of a `for` loop (no manual copy) and explain in a comment why the output differs from the uncorrected `for` loop version.

**Deliverable:** Console app showing the buggy output, the fixed output, and the `foreach` comparison, each clearly labeled.

---

### Lab 8 — Delegates as Callback Parameters (Mini Design Task)

1. Write `void ProcessBatch<T>(List<T> items, Action<T> onSuccess, Action<T, string> onFailure, Func<T, bool> validator)` that, for each item: validates it, then calls `onSuccess` if valid or `onFailure` with a reason string if not.
2. Call `ProcessBatch` against a `List<int>` where the validator rejects negative numbers, with lambda handlers that print success/failure messages differently.
3. Call it again against a `List<string>` where the validator rejects empty/whitespace strings, reusing the same generic method.

**Deliverable:** Console app proving the same generic callback-driven method works correctly for two unrelated types and validation rules.

---

## Submission Checklist

- [ ] Code compiles with zero warnings
- [ ] Each lab clearly labeled in output (menu or sequential method calls with headers)
- [ ] No unhandled exceptions — deliberate failure/pitfall cases are shown and explained, not left to crash the program
- [ ] At least one custom delegate type declared and used (Labs 2–3)
- [ ] At least one use each of `Func<>`, `Action<>`, and `Predicate<T>`/`Func<T,bool>` (Lab 4)
- [ ] The loop-variable capture pitfall is demonstrated AND fixed (Lab 7)
