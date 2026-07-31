# ⏳ 2D Array - DS (HackerRank)

A C# implementation of the **2D Array - DS** problem from HackerRank. This project demonstrates how to traverse a **6 × 6 two-dimensional array** and efficiently calculate the **maximum hourglass sum**.

> **Data Structure:** 2D Array (Matrix)  
> **Technique Used:** Matrix Traversal

---

## 🎯 Problem Statement

Given a **6 × 6 two-dimensional array** of integers, an **hourglass** is a subset of values with the following shape:

```text
a b c
  d
e f g
```

Your task is to calculate the sum of **every possible hourglass** in the array and return the **maximum hourglass sum**.

A **6 × 6** array contains exactly **16 possible hourglasses**.

Complete the following function:

```csharp
hourglassSum(List<List<int>> arr)
```

---

## 📥 Input Format

- The input consists of **6 lines**.
- Each line contains **6 space-separated integers**.

### Constraints

- Array size is always **6 × 6**
- **-9 ≤ arr[i][j] ≤ 9**

---

## 📤 Output Format

Return an integer representing the **maximum hourglass sum**.

---

## ✅ Sample Input

```text
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
```

### Sample Output

```text
19
```

---

## 📌 Explanation

The maximum hourglass is:

```text
2 4 4
  2
1 2 4
```

### Hourglass Sum

```text
2 + 4 + 4 + 2 + 1 + 2 + 4 = 19
```

---

## 📚 Another Example

### Input

```text
-9 -9 -9 1 1 1
0 -9 0 4 3 2
-9 -9 -9 1 2 3
0 0 8 6 6 0
0 0 0 -2 0 0
0 0 1 2 4 0
```

### Output

```text
28
```

---

# ⚙️ Algorithm

1. Initialize the maximum sum with the smallest possible integer value.
2. Traverse the matrix from **row 0 to row 3** and **column 0 to column 3**.
3. For each position, calculate the hourglass sum using:

```text
a b c
  d
e f g
```

4. Compare the current hourglass sum with the maximum sum.
5. Update the maximum if a larger sum is found.
6. Return the maximum hourglass sum.

---

# 📊 Program Output

### Example 1

```text
Input:
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0

Output:
19
```

### Example 2

```text
Input:
-9 -9 -9 1 1 1
0 -9 0 4 3 2
-9 -9 -9 1 2 3
0 0 8 6 6 0
0 0 0 -2 0 0
0 0 1 2 4 0

Output:
28
```

---

# 🧠 Concepts Used

- Two-Dimensional Arrays
- Matrix Traversal
- Nested Loops
- Pattern Recognition
- Maximum Value Tracking
- Time & Space Complexity Analysis

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(1)** |
| Space Complexity | **O(1)** |

Since the matrix size is always **6 × 6**, only **16 hourglasses** are evaluated, making the execution time constant.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Traverse a 2D array efficiently
- Identify and process hourglass patterns
- Calculate aggregate values within a matrix
- Track maximum values
- Apply nested loop traversal techniques
- Solve matrix-based coding interview problems

---

## 📷 Sample Output

```text
Input:
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0

Output:
19
```

```text
Input:
-9 -9 -9 1 1 1
0 -9 0 4 3 2
-9 -9 -9 1 2 3
0 0 8 6 6 0
0 0 0 -2 0 0
0 0 1 2 4 0

Output:
28
```