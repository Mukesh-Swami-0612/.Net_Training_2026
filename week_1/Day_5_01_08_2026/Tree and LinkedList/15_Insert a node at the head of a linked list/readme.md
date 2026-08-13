# 🔗 Insert a Node at the Head of a Linked List (HackerRank)

A C# implementation of the **Insert a Node at the Head of a Linked List** problem from HackerRank. This project demonstrates how to insert a new node at the **beginning (head)** of a **Singly Linked List**.

> **Data Structure:** Singly Linked List  
> **Technique Used:** Head Insertion & Pointer Manipulation

---

## 🎯 Problem Statement

Given the head of a **Singly Linked List** and an integer value, insert a new node containing the given value at the **head (beginning)** of the linked list.

If the linked list is empty, the new node becomes the head of the list.

Complete the following function:

```csharp
insertNodeAtHead(SinglyLinkedListNode llist, int data)
```

---

## 📥 Parameters

| Parameter | Description |
|-----------|-------------|
| `llist` | Head node of the linked list |
| `data` | Integer value to be inserted at the beginning |

---

## 📤 Return Value

Return the **head of the updated linked list**.

---

## ✅ Sample Input

```text
Number of Nodes:
5

Values:
383
484
392
975
321
```

### Sample Output

```text
321 975 392 484 383
```

---

## 📌 Explanation

Initially, the linked list is empty.

Each value is inserted at the **head** of the linked list.

Insertion sequence:

```text
Insert 383:
383

Insert 484:
484 → 383

Insert 392:
392 → 484 → 383

Insert 975:
975 → 392 → 484 → 383

Insert 321:
321 → 975 → 392 → 484 → 383
```

Final linked list:

```text
321 → 975 → 392 → 484 → 383
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
40 → 30 → 20 → 10
```

---

# 📝 Dry Run

Suppose the linked list is:

```text
20 → 30 → 40
```

Insert:

```text
10
```

### Steps

| Step | Action | Linked List |
|------|--------|-------------|
| 1 | Create new node (10) | 10 |
| 2 | Point new node to current head | 10 → 20 → 30 → 40 |
| 3 | Update head to new node | 10 → 20 → 30 → 40 |

### Final Linked List

```text
10 → 20 → 30 → 40
```

---

# ⚙️ Algorithm

1. Create a new node with the given data.
2. Set the new node's `next` pointer to the current head.
3. Update the head to the new node.
4. Return the updated head.

---

# 📊 Program Output

### Example 1

```text
Input:
383
484
392
975
321

Output:
321 → 975 → 392 → 484 → 383
```

### Example 2

```text
Input:
10
20
30
40

Output:
40 → 30 → 20 → 10
```

---

# 🧠 Concepts Used

- Singly Linked List
- Head Insertion
- Pointer Manipulation
- Dynamic Memory Allocation
- Linked List Operations

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(1)** |
| Space Complexity | **O(1)** |

The insertion is performed directly at the beginning of the list without traversing any nodes, making it an optimal constant-time operation.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Insert a node at the beginning of a linked list
- Update the head pointer correctly
- Handle insertion into an empty linked list
- Understand pointer manipulation in linked lists
- Perform constant-time insertion operations
- Solve linked list interview problems efficiently

---

## 📷 Sample Output

```text
Input:
383
484
392
975
321

Output:
321 → 975 → 392 → 484 → 383
```

```text
Input:
10
20
30
40

Output:
40 → 30 → 20 → 10
```