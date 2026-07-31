# 🔗 Insert a Node at a Specific Position in a Linked List (HackerRank)

A C# implementation of the **Insert a Node at a Specific Position in a Linked List** problem from HackerRank. This project demonstrates how to insert a new node into a **Singly Linked List** at a specified position while maintaining the list structure.

> **Data Structure:** Singly Linked List  
> **Technique Used:** Linked List Traversal & Node Insertion

---

## 🎯 Problem Statement

Given the head of a **Singly Linked List**, a value to insert, and a zero-based position, insert a new node containing the given value at the specified position.

The position will always be valid, meaning it will be within the current length of the list.

Complete the following function:

```csharp
insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
```

---

## 📥 Parameters

| Parameter | Description |
|-----------|-------------|
| `llist` | Head node of the linked list |
| `data` | Value to be inserted |
| `position` | Zero-based index where the new node should be inserted |

---

## 📤 Return Value

Return the **head of the updated linked list**.

---

## ✅ Sample Input

```text
Linked List:
16 → 13 → 7

Data:
1

Position:
2
```

### Sample Output

```text
16 → 13 → 1 → 7
```

---

## 📌 Explanation

### Original Linked List

```text
16 → 13 → 7
```

Insert **1** at **position 2**.

### Updated Linked List

```text
16 → 13 → 1 → 7
```

The new node is inserted between **13** and **7**.

---

## 📚 Another Example

### Input

```text
Linked List:
10 → 20 → 40 → 50

Data:
30

Position:
2
```

### Output

```text
10 → 20 → 30 → 40 → 50
```

---

# 📝 Dry Run

Suppose:

```text
Linked List:
16 → 13 → 7

Insert:
1

Position:
2
```

| Step | Current Node | Action |
|------|--------------|--------|
| Start | 16 | Position = 0 |
| Move | 13 | Position = 1 |
| Stop | 13 | Reached node before insertion position |
| Insert | 1 | Link new node to 7 |
| Update | 13 | Link 13 to new node |

### Final List

```text
16 → 13 → 1 → 7
```

---

# ⚙️ Algorithm

1. Create a new node with the given data.
2. If the position is **0**, insert the node at the beginning.
3. Traverse the linked list until reaching the node just before the desired position.
4. Update the new node's `next` pointer to point to the next node.
5. Update the previous node's `next` pointer to point to the new node.
6. Return the head of the updated linked list.

---

# 📊 Program Output

### Example 1

```text
Input:
16 → 13 → 7

Insert:
1

Position:
2

Output:
16 → 13 → 1 → 7
```

### Example 2

```text
Input:
10 → 20 → 40 → 50

Insert:
30

Position:
2

Output:
10 → 20 → 30 → 40 → 50
```

---

# 🧠 Concepts Used

- Singly Linked List
- Node Traversal
- Node Insertion
- Pointer Manipulation
- Dynamic Memory Allocation
- Linked List Operations

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(1)** |

- **Time Complexity:** O(n), since the list may need to be traversed up to the insertion position.
- **Space Complexity:** O(1), as only one new node is created.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Traverse a singly linked list
- Insert a node at any valid position
- Update node references correctly
- Handle insertion at the beginning and middle of the list
- Understand pointer manipulation in linked lists
- Solve linked list interview problems efficiently

---

## 📷 Sample Output

```text
Input:
16 → 13 → 7

Insert:
1

Position:
2

Output:
16 → 13 → 1 → 7
```

```text
Input:
10 → 20 → 40 → 50

Insert:
30

Position:
2

Output:
10 → 20 → 30 → 40 → 50
```