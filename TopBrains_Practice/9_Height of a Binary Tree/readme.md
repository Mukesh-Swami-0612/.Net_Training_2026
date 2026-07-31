# 🌳 Tree: Height of a Binary Tree (HackerRank)

A C# implementation of the **Tree: Height of a Binary Tree** problem from HackerRank. This project demonstrates how to calculate the **height of a binary tree** using a recursive **Depth-First Search (DFS)** approach.

> **Data Structure:** Binary Tree  
> **Technique Used:** Recursion (Depth-First Search)

---

## 🎯 Problem Statement

Given the root of a binary tree, determine its **height**.

The **height** of a binary tree is defined as the **number of edges on the longest path from the root node to a leaf node**.

Complete the following function:

```csharp
height(Node root)
```

---

## 📥 Parameter

| Parameter | Description |
|-----------|-------------|
| `root` | Root node of the binary tree |

---

## 📤 Return Value

Return an integer representing the **height** of the binary tree.

---

## 🌲 Example Tree

```text
        3
       / \
      5   2
     / \
    1   4
```

---

## ✅ Sample Input

```text
        3
       / \
      5   2
     / \
    1   4
```

### Sample Output

```text
2
```

---

## 📌 Explanation

The longest path from the root to any leaf is:

```text
3 → 5 → 1
```

or

```text
3 → 5 → 4
```

Both paths contain **2 edges**, so the height of the tree is:

```text
2
```

---

## 📚 Another Example

### Input

```text
        1
         \
          2
           \
            3
             \
              4
```

### Output

```text
3
```

---

# 📝 Dry Run

For the tree:

```text
        3
       / \
      5   2
     / \
    1   4
```

### Step-by-Step Calculation

| Node | Left Height | Right Height | Height |
|------|------------:|-------------:|-------:|
| 1 | -1 | -1 | 0 |
| 4 | -1 | -1 | 0 |
| 2 | -1 | -1 | 0 |
| 5 | 0 | 0 | 1 |
| 3 | 1 | 0 | 2 |

Final Answer:

```text
Height = 2
```

---

# ⚙️ Algorithm

1. If the current node is `null`, return **-1**.
2. Recursively calculate the height of the left subtree.
3. Recursively calculate the height of the right subtree.
4. Return:

```text
1 + max(leftHeight, rightHeight)
```

5. The returned value from the root node is the height of the binary tree.

---

# 📊 Program Output

### Example 1

```text
Input Tree:

        3
       / \
      5   2
     / \
    1   4

Output:
2
```

### Example 2

```text
Input Tree:

        1
         \
          2
           \
            3
             \
              4

Output:
3
```

---

# 🧠 Concepts Used

- Binary Tree
- Tree Height
- Recursion
- Depth-First Search (DFS)
- Divide and Conquer
- Recursive Tree Traversal

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(h)** |

Where:

- **n** = Number of nodes in the tree
- **h** = Height of the tree (recursive call stack)

### Cases

- **Balanced Tree:** O(log n) auxiliary space
- **Skewed Tree:** O(n) auxiliary space

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Calculate the height of a binary tree
- Apply recursion to tree problems
- Traverse trees using Depth-First Search (DFS)
- Determine the longest root-to-leaf path
- Analyze recursive algorithm complexity
- Solve binary tree interview questions efficiently

---

## 📷 Sample Output

```text
Input Tree:

        3
       / \
      5   2
     / \
    1   4

Output:
2
```

```text
Input Tree:

        1
         \
          2
           \
            3
             \
              4

Output:
3
```