# 🔗 Insert a Node at the Tail of a Linked List (HackerRank)

A C# implementation of the **Insert a Node at the Tail of a Linked List** problem from HackerRank. This project demonstrates how to insert a new node at the **end (tail)** of a **Singly Linked List**.

> **Data Structure:** Singly Linked List  
> **Technique Used:** Linked List Traversal & Tail Insertion

---

## 🎯 Problem Statement

Given the head of a **Singly Linked List** and an integer value, insert a new node containing the value at the **tail (end)** of the linked list.

If the linked list is empty, the new node becomes the head of the list.

Complete the following function:

```csharp
insertNodeAtTail(SinglyLinkedListNode head, int data)
```

---

## 📥 Parameters

| Parameter | Description |
|-----------|-------------|
| `head` | Head node of the linked list |
| `data` | Integer value to be inserted at the tail |

---

## 📤 Return Value

Return the **head of the updated linked list**.

---

## ✅ Sample Input

```text
Number of Nodes:
5

Values:
141
302
164
530
474
```

### Sample Output

```text
141 302 164 530 474
```

---

## 📌 Explanation

Initially, the linked list is empty.

Each value is inserted one by one at the **tail** of the linked list.

Final linked list:

```text
141 → 302 → 164 → 530 → 474
```

---

## 📚 Another Example

### Input

```text
Number of Nodes:
4

Values:
10
20
30
40
```

### Output

```text
10 → 20 → 30 → 40
```

---

# 📝 Dry Run

Suppose the linked list is:

```text
10 → 20 → 30
```

Insert:

```text
40
```

### Steps

| Step | Current Node | Action |
|------|--------------|--------|
| 1 | 10 | Move to next node |
| 2 | 20 | Move to next node |
| 3 | 30 | Tail reached |
| 4 | 30 | Set `30.next = 40` |

### Final Linked List

```text
10 → 20 → 30 → 40
```

---

# ⚙️ Algorithm

1. Create a new node containing the given data.
2. If the linked list is empty, return the new node as the head.
3. Traverse the linked list until the last node is reached.
4. Set the last node's `next` pointer to the new node.
5. Return the head of the updated linked list.

---

# 📊 Program Output

### Example 1

```text
Input:
141
302
164
530
474

Output:
141 → 302 → 164 → 530 → 474
```

### Example 2

```text
Input:
10
20
30
40

Output:
10 → 20 → 30 → 40
```

---

# 🧠 Concepts Used

- Singly Linked List
- Tail Insertion
- Node Traversal
- Pointer Manipulation
- Dynamic Memory Allocation
- Linked List Operations

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(1)** |

Where:

- **n** = Number of nodes in the linked list

The algorithm traverses the list once to reach the tail and inserts the new node without using any extra data structures.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Insert a node at the end of a singly linked list
- Traverse a linked list efficiently
- Handle insertion into an empty linked list
- Update node references correctly
- Understand tail insertion operations
- Solve linked list interview problems using C#

---

## 📷 Sample Output

```text
Input:
141
302
164
530
474

Output:
141 → 302 → 164 → 530 → 474
```

```text
Input:
10
20
30
40

Output:
10 → 20 → 30 → 40
```