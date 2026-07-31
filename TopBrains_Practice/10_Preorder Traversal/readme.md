# 🌳 Tree: Preorder Traversal (HackerRank)

A C# implementation of the **Tree: Preorder Traversal** problem from HackerRank. This project demonstrates how to perform a **Preorder Traversal** on a **Binary Tree** using recursion.

> **Data Structure:** Binary Tree  
> **Traversal Technique:** Preorder Traversal (Root → Left → Right)

---

## 🎯 Problem Statement

Given the root of a binary tree, perform a **Preorder Traversal** and print the value of each node.

In a **Preorder Traversal**, nodes are visited in the following order:

```text
Current Node
      ↓
Left Subtree
      ↓
Right Subtree
```

Complete the following function:

```csharp
preOrder(Node root)
```

---

## 📥 Parameter

| Parameter | Description |
|-----------|-------------|
| `root` | Root node of the binary tree |

---

## 📤 Output Format

Print the values of the nodes in **Preorder Traversal** order, separated by spaces.

---

## 🌲 Example Tree

```text
        1
         \
          2
         /
        3
```

---

## ✅ Sample Input

```text
        1
         \
          2
         /
        3
```

### Sample Output

```text
1 2 3
```

---

## 📌 Explanation

Traversal order:

1. Visit the **root node (1)**.
2. Traverse the left subtree (none).
3. Traverse the right subtree (2).
4. Visit node **2**.
5. Traverse its left subtree (**3**).
6. Visit node **3**.

Result:

```text
1 2 3
```

---

## 📚 Another Example

### Input

```text
          4
        /   \
       2     6
      / \   / \
     1   3 5   7
```

### Output

```text
4 2 1 3 6 5 7
```

---

# 📝 Dry Run

For the tree:

```text
          4
        /   \
       2     6
      / \   / \
     1   3 5   7
```

| Step | Node Visited | Output |
|------|--------------|--------|
| 1 | 4 | 4 |
| 2 | 2 | 4 2 |
| 3 | 1 | 4 2 1 |
| 4 | 3 | 4 2 1 3 |
| 5 | 6 | 4 2 1 3 6 |
| 6 | 5 | 4 2 1 3 6 5 |
| 7 | 7 | 4 2 1 3 6 5 7 |

---

# ⚙️ Algorithm

1. If the current node is `null`, return.
2. Visit and print the current node.
3. Recursively traverse the left subtree.
4. Recursively traverse the right subtree.
5. Continue until all nodes have been visited.

---

# 📊 Program Output

### Example 1

```text
Input Tree:

        1
         \
          2
         /
        3

Output:
1 2 3
```

### Example 2

```text
Input Tree:

          4
        /   \
       2     6
      / \   / \
     1   3 5   7

Output:
4 2 1 3 6 5 7
```

---

# 🧠 Concepts Used

- Binary Tree
- Preorder Traversal
- Recursion
- Depth-First Search (DFS)
- Tree Traversal
- Recursive Function Calls

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

- Traverse a binary tree using Preorder Traversal
- Apply recursion to tree-based problems
- Understand the Root → Left → Right traversal order
- Use Depth-First Search (DFS) techniques
- Analyze recursive algorithm complexity
- Solve binary tree coding interview questions

---

## 📷 Sample Output

```text
Input Tree:

        1
         \
          2
         /
        3

Output:
1 2 3
```

```text
Input Tree:

          4
        /   \
       2     6
      / \   / \
     1   3 5   7

Output:
4 2 1 3 6 5 7
```