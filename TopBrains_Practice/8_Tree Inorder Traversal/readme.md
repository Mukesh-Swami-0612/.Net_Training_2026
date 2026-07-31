# 🌳 Tree: Inorder Traversal (HackerRank)

A C# implementation of the **Tree: Inorder Traversal** problem from HackerRank. This project demonstrates how to perform an **Inorder Traversal** on a **Binary Tree** using recursion.

> **Data Structure:** Binary Tree  
> **Traversal Technique:** Inorder Traversal (Left → Root → Right)

---

## 🎯 Problem Statement

Given the root of a binary tree, perform an **Inorder Traversal** and print the value of each node.

In an **Inorder Traversal**, nodes are visited in the following order:

```text
Left Subtree
      ↓
Current Node
      ↓
Right Subtree
```

Complete the following function:

```csharp
inOrder(Node root)
```

---

## 📥 Parameter

| Parameter | Description |
|-----------|-------------|
| `root` | Root node of the binary tree |

---

## 📤 Output Format

Print the values of the nodes in **Inorder Traversal** order, separated by spaces.

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
1 3 2
```

---

## 📌 Explanation

Traversal order:

1. Visit the left subtree of node **1** (none).
2. Visit node **1**.
3. Move to node **2**.
4. Visit the left subtree (**3**).
5. Visit node **3**.
6. Visit node **2**.

Result:

```text
1 3 2
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
1 2 3 4 5 6 7
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

| Step | Node | Action | Output |
|------|------|--------|--------|
| 1 | 1 | Visit Left → Root | 1 |
| 2 | 2 | Visit Root | 1 2 |
| 3 | 3 | Visit Right | 1 2 3 |
| 4 | 4 | Visit Root | 1 2 3 4 |
| 5 | 5 | Visit Left | 1 2 3 4 5 |
| 6 | 6 | Visit Root | 1 2 3 4 5 6 |
| 7 | 7 | Visit Right | 1 2 3 4 5 6 7 |

---

# ⚙️ Algorithm

1. If the current node is `null`, return.
2. Recursively traverse the left subtree.
3. Print the current node's value.
4. Recursively traverse the right subtree.
5. Continue until all nodes are visited.

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
1 3 2
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
1 2 3 4 5 6 7
```

---

# 🧠 Concepts Used

- Binary Tree
- Inorder Traversal
- Recursion
- Tree Traversal
- Depth-First Search (DFS)
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

- **Worst Case:** O(n) (Skewed Tree)
- **Balanced Tree:** O(log n)

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Traverse a binary tree using recursion
- Perform Inorder Traversal (Left → Root → Right)
- Understand recursive tree algorithms
- Apply Depth-First Search (DFS)
- Analyze tree traversal complexity
- Solve binary tree interview problems

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
1 3 2
```

```text
Input Tree:

        4
      /   \
     2     6
    / \   / \
   1   3 5   7

Output:
1 2 3 4 5 6 7
```