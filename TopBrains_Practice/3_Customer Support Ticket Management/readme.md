# 🎫 Customer Support Ticket Management System

A Queue-based implementation of a **Customer Support Ticket Management System** that processes customer service requests using the **First-In, First-Out (FIFO)** principle.

> **Data Structure:** Queue (FIFO)  
> The first ticket received is always the first ticket processed.

---

## 🎯 Scenario

A customer support center receives service requests throughout the day. Since tickets must be handled in the order they arrive, a **Queue** is the ideal data structure for managing customer requests efficiently.

---

## 📝 Initial Support Tickets

| Ticket ID | Customer | Issue Type | Description |
|-----------|----------|------------|-------------|
| 101 | Rahul | Technical | Internet connection issue |
| 102 | Priya | Billing | Incorrect bill amount |
| 103 | Amit | Login | Unable to login |
| 104 | Neha | Technical | Application crashes |
| 105 | Rohan | Account | Update profile details |

---

## ✅ Tasks Performed

- Enqueue customer support tickets
- Display all pending tickets
- Process the first ticket (Dequeue)
- View the next ticket (Peek)
- Count pending tickets
- Search for a ticket by ID
- Count tickets based on issue type
- Remove all processed tickets

---

# 📊 Program Output

```text
==============================================
 Customer Support Ticket Management System
==============================================

TASK 1 : Enqueue Tickets

Ticket 101 added successfully.
Ticket 102 added successfully.
Ticket 103 added successfully.
Ticket 104 added successfully.
Ticket 105 added successfully.

TASK 2 : Display All Tickets

Current Tickets:

ID: 101 | Customer: Rahul | Issue: Technical | Description: Internet connection issue
ID: 102 | Customer: Priya | Issue: Billing | Description: Incorrect bill amount
ID: 103 | Customer: Amit | Issue: Login | Description: Unable to login
ID: 104 | Customer: Neha | Issue: Technical | Description: Application crashes
ID: 105 | Customer: Rohan | Issue: Account | Description: Update profile details

TASK 3 : Process First Ticket

Processed Ticket:
ID: 101 | Customer: Rahul | Issue: Technical | Description: Internet connection issue

TASK 4 : View Next Ticket

Next Ticket:
ID: 102 | Customer: Priya | Issue: Billing | Description: Incorrect bill amount

TASK 5 : Queue Count

Pending Tickets : 4

TASK 6 : Search Ticket By ID

Ticket Found
ID: 104 | Customer: Neha | Issue: Technical | Description: Application crashes

TASK 7 : Count Tickets By Issue Type

Billing : 1
Login : 1
Technical : 1
Account : 1

TASK 8 : Remove All Tickets

All tickets have been removed.

Remaining Tickets : 0

Program Executed Successfully.
```

---

## 📌 Results

### 1️⃣ Enqueue Tickets

Five customer support tickets are successfully added to the queue in the order they are received.

---

### 2️⃣ Display All Tickets

All pending tickets are displayed while maintaining the original arrival order.

---

### 3️⃣ Process First Ticket (Dequeue)

**Processed Ticket:**

```text
ID: 101 | Customer: Rahul | Issue: Technical
```

The first ticket is removed from the queue following the **FIFO** principle.

---

### 4️⃣ View Next Ticket (Peek)

**Next Ticket:**

```text
ID: 102 | Customer: Priya | Issue: Billing
```

The next ticket is viewed without removing it from the queue.

---

### 5️⃣ Queue Count

**Output:**

```text
Pending Tickets : 4
```

After processing one ticket, four customer requests remain in the queue.

---

### 6️⃣ Search Ticket by ID

**Output:**

```text
Ticket Found
ID: 104 | Customer: Neha | Issue: Technical
```

The system successfully locates the requested ticket using its unique Ticket ID.

---

### 7️⃣ Count Tickets by Issue Type

**Output:**

```text
Billing : 1
Login : 1
Technical : 1
Account : 1
```

After processing the first ticket, the remaining tickets are categorized by issue type.

---

### 8️⃣ Remove All Tickets

**Output:**

```text
All tickets have been removed.

Remaining Tickets : 0
```

All pending tickets are cleared, leaving the queue empty.

---

# 🧠 Queue Concepts Used

- Queue (FIFO)
- Enqueue Operation
- Dequeue Operation
- Peek Operation
- Queue Traversal
- Search Operation
- Counting & Grouping
- Queue Size Management

---

## 🎓 Learning Outcomes

This project demonstrates how the **Queue** data structure can efficiently manage customer support requests by:

- Processing tickets in arrival order (FIFO)
- Managing pending service requests
- Searching tickets using Ticket ID
- Categorizing tickets by issue type
- Tracking queue size
- Clearing completed requests

---

## 📷 Sample Output

```text
==============================================
 Customer Support Ticket Management System
==============================================

✓ Enqueue Tickets
✓ Display Tickets
✓ Process First Ticket
✓ View Next Ticket
✓ Queue Count
✓ Search Ticket
✓ Count by Issue Type
✓ Remove All Tickets

Program Executed Successfully.
```