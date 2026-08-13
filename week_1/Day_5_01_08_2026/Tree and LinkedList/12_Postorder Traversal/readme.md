# 🌳 Tree: Postorder Traversal (HackerRank)

A C# implementation of the **Tree: Postorder Traversal** problem from HackerRank. This project demonstrates how to perform a **Postorder Traversal** on a **Binary Tree** using recursion.

> **Data Structure:** Binary Tree  
> **Traversal Technique:** Postorder Traversal (Left → Right → Root)

---

## 🎯 Problem Statement

Given the root of a binary tree, print the values of the nodes in **Postorder Traversal** order.

In a **Postorder Traversal**, the nodes are visited in the following sequence:

```text
Left Subtree
      ↓
Right Subtree
      ↓
Current Node (Root)
```

Complete the following function:

```csharp
PostOrder(Node root)
```

---

## 📥 Parameter

| Parameter | Description |
|-----------|-------------|
| `root` | Root node of the binary tree |

---

## 📤 Output Format

Print the values of the binary tree in **Postorder Traversal** as a single line of **space-separated integers**.

---

## 🌲 Sample Tree

```text
     1
      \
       2
        \
         5
        / \
       3   6
        \
         4
```

---

## ✅ Sample Input

```text
     1
      \
       2
        \
         5
        / \
       3   6
        \
         4
```

### Sample Output

```text
4 3 6 5 2 1
```

---

## 📌 Explanation

The traversal follows the **Left → Right → Root** order.

Traversal Steps:

1. Traverse the left subtree (if any).
2. Traverse the right subtree.
3. Visit the current node.

For the given tree:

```text
     1
      \
       2
        \
         5
        / \
       3   6
        \
         4
```

The nodes are visited in this order:

```text
4 → 3 → 6 → 5 → 2 → 1
```

Therefore, the output is:

```text
4 3 6 5 2 1
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
1 3 2 5 7 6 4
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
| 1 | 1 | 1 |
| 2 | 3 | 1 3 |
| 3 | 2 | 1 3 2 |
| 4 | 5 | 1 3 2 5 |
| 5 | 7 | 1 3 2 5 7 |
| 6 | 6 | 1 3 2 5 7 6 |
| 7 | 4 | 1 3 2 5 7 6 4 |

---

# ⚙️ Algorithm

1. If the current node is `null`, return.
2. Recursively traverse the left subtree.
3. Recursively traverse the right subtree.
4. Print the current node's value.
5. Continue until all nodes have been visited.

---

# 📊 Program Output

### Example 1

```text
Input Tree:

     1
      \
       2
        \
         5
        / \
       3   6
        \
         4

Output:
4 3 6 5 2 1
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
1 3 2 5 7 6 4
```

---

# 🧠 Concepts Used

- Binary Tree
- Postorder Traversal
- Depth-First Search (DFS)
- Recursion
- Tree Traversal
- Recursive Algorithms

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(h)** |

Where:

- **n** = Number of nodes in the tree
- **h** = Height of the tree

### Cases

- **Balanced Tree:** **O(log n)** auxiliary space
- **Skewed Tree:** **O(n)** auxiliary space

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Perform Postorder Traversal on a binary tree
- Apply recursion for tree traversal
- Understand the **Left → Right → Root** traversal sequence
- Use Depth-First Search (DFS) techniques
- Analyze recursive algorithm complexity
- Solve binary tree traversal problems commonly asked in coding interviews

---

## 📷 Sample Output

```text
Input Tree:

     1
      \
       2
        \
         5
        / \
       3   6
        \
         4

Output:
4 3 6 5 2 1
```

```text
Input Tree:

          4
        /   \
       2     6
      / \   / \
     1   3 5   7

Output:
1 3 2 5 7 6 4
```