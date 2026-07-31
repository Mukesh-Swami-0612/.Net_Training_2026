# 🔄 Arrays - DS (HackerRank)

A C# implementation of the **Arrays - DS** problem from HackerRank. This project demonstrates how to reverse an array efficiently using the **Two Pointer** technique without using any built-in reverse function.

> **Data Structure:** Array  
> **Technique Used:** Two Pointer (In-Place Reversal)

---

## 🎯 Problem Statement

An array is a data structure that stores elements of the same type in contiguous memory.

Given an array of integers, reverse the elements of the array and return the reversed array.

Complete the following function:

```csharp
reverseArray(List<int> a)
```

---

## 📥 Input Format

- The first line contains an integer **n**, representing the number of elements.
- The second line contains **n** space-separated integers.

### Constraints

- **1 ≤ n ≤ 1000**
- **1 ≤ a[i] ≤ 10000**

---

## 📤 Output Format

Return a list containing the elements of the original array in reverse order.

---

## ✅ Sample Input

```text
4

1 4 3 2
```

### Sample Output

```text
2 3 4 1
```

---

## 📌 Explanation

### Original Array

```text
1 4 3 2
```

### Reversed Array

```text
2 3 4 1
```

---

## 📚 Another Example

### Input

```text
5

10 20 30 40 50
```

### Output

```text
50 40 30 20 10
```

---

# 📝 Dry Run

| Step | Left | Right | Array |
|------|------|-------|-------|
| Initial | 0 | 3 | 1 4 3 2 |
| Swap 1 & 2 | 1 | 2 | 2 4 3 1 |
| Swap 4 & 3 | 2 | 1 | 2 3 4 1 |
| Stop | Left ≥ Right | — | 2 3 4 1 |

---

# ⚙️ Algorithm

1. Initialize two pointers:
   - `left = 0`
   - `right = n - 1`
2. Swap the elements at the `left` and `right` indices.
3. Increment `left` and decrement `right`.
4. Repeat until `left >= right`.
5. Return the reversed array.

---

# 📊 Program Output

### Example 1

```text
Input:
4
1 4 3 2

Output:
2 3 4 1
```

### Example 2

```text
Input:
5
10 20 30 40 50

Output:
50 40 30 20 10
```

---

# 🧠 Concepts Used

- Arrays
- Two Pointer Technique
- In-Place Swapping
- Iteration
- Time and Space Complexity Analysis

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(1)** |

The algorithm reverses the array **in-place**, making it the most efficient solution without using any additional data structures.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Reverse an array efficiently
- Apply the Two Pointer technique
- Perform in-place swapping
- Optimize space complexity
- Solve array-based interview problems
- Understand time and space complexity

---

## 📷 Sample Output

```text
Input:
4
1 4 3 2

Output:
2 3 4 1
```

```text
Input:
5
10 20 30 40 50

Output:
50 40 30 20 10
```