# 🛒 E-Commerce Order Management System

A **String Handling** based implementation of an **E-Commerce Order Management System** that processes customer order records stored as **pipe (`|`) separated strings** using C# string methods.

> **Concept:** String Manipulation & Data Processing  
> Each order is stored as a text record and parsed using C# string operations.

---

## 🎯 Scenario

An e-commerce company stores customer order details in a text file. Each order record is saved as a **pipe (`|`) separated string**.

As a .NET developer, the objective is to process these records using various **C# String methods** to perform searching, updating, filtering, and reporting operations.

---

## 📦 Sample Order Records

| Order ID | Customer | Product | Quantity | Price | Status |
|----------|----------|---------|---------:|------:|---------|
| 101 | Rahul | Laptop | 2 | ₹55,000 | Pending |
| 102 | Priya | Mouse | 3 | ₹750 | Delivered |
| 103 | Amit | Keyboard | 1 | ₹1,800 | Pending |
| 104 | Neha | Monitor | 2 | ₹12,000 | Processing |
| 105 | Rahul | Headphones | 1 | ₹2,500 | Delivered |

---

## ✅ Tasks Performed

- Display all customer orders
- Search an order by Order ID
- Calculate total sales
- Count orders by status
- Display all orders of a specific customer
- Convert customer names to uppercase
- Update pending orders
- Display total number of orders

---

# 📊 Program Output

```text
======================================
 E-Commerce Order Management System
======================================

1. Display All Orders
----------------------------

Order ID : 101
Customer : Rahul
Product  : Laptop
Quantity : 2
Price    : ₹55000
Status   : Pending
Total    : ₹110000

Order ID : 102
Customer : Priya
Product  : Mouse
Quantity : 3
Price    : ₹750
Status   : Delivered
Total    : ₹2250

Order ID : 103
Customer : Amit
Product  : Keyboard
Quantity : 1
Price    : ₹1800
Status   : Pending
Total    : ₹1800

Order ID : 104
Customer : Neha
Product  : Monitor
Quantity : 2
Price    : ₹12000
Status   : Processing
Total    : ₹24000

Order ID : 105
Customer : Rahul
Product  : Headphones
Quantity : 1
Price    : ₹2500
Status   : Delivered
Total    : ₹2500


2. Search Order By ID
----------------------------

Order Found

Order ID : 103
Customer : Amit
Product  : Keyboard
Quantity : 1
Price    : ₹1800
Status   : Pending
Total    : ₹1800


3. Calculate Total Sales
----------------------------

Total Sales : ₹140550


4. Count Orders By Status
----------------------------

Pending : 2
Delivered : 2
Processing : 1


5. Display Orders of Rahul
----------------------------

Order ID : 101
Customer : Rahul
Product  : Laptop
Quantity : 2
Price    : ₹55000
Status   : Pending
Total    : ₹110000

Order ID : 105
Customer : Rahul
Product  : Headphones
Quantity : 1
Price    : ₹2500
Status   : Delivered
Total    : ₹2500


6. Convert Customer Names To Uppercase
----------------------------

Customer names converted to uppercase.


7. Update Pending Orders
----------------------------

Pending orders updated successfully.


8. Total Orders
----------------------------

Total Orders : 5

Program completed successfully.
```

---

## 📌 Results

### 1️⃣ Display All Orders

All customer orders are parsed from the input strings and displayed in a structured format with order details and calculated totals.

---

### 2️⃣ Search Order by ID

**Output:**

```text
Order Found

Order ID : 103
Customer : Amit
Product  : Keyboard
```

The system successfully searches and retrieves an order using its unique Order ID.

---

### 3️⃣ Calculate Total Sales

**Output:**

```text
Total Sales : ₹140550
```

The application calculates the overall revenue by summing the total value of every order.

---

### 4️⃣ Count Orders by Status

**Output:**

```text
Pending : 2
Delivered : 2
Processing : 1
```

Orders are grouped and counted according to their current processing status.

---

### 5️⃣ Display Orders of Rahul

**Output:**

```text
Order ID : 101
Order ID : 105
```

The system filters and displays all orders belonging to customer **Rahul**.

---

### 6️⃣ Convert Customer Names to Uppercase

**Output:**

```text
Customer names converted to uppercase.
```

All customer names are converted to uppercase using C# string methods.

---

### 7️⃣ Update Pending Orders

**Output:**

```text
Pending orders updated successfully.
```

Orders with **Pending** status are updated as required by the application logic.

---

### 8️⃣ Total Orders

**Output:**

```text
Total Orders : 5
```

The application displays the total number of order records available.

---

# 🧠 String Handling Concepts Used

- String.Split()
- String.Trim()
- String.Replace()
- String.ToUpper()
- String Comparison
- Searching & Filtering
- Parsing Delimited Data
- Aggregation & Counting

---

## 🎓 Learning Outcomes

This project demonstrates how **C# String Handling** can be used to process structured text data by:

- Parsing pipe-separated records
- Searching orders efficiently
- Calculating sales totals
- Filtering customer orders
- Updating order status
- Counting records by category
- Formatting and displaying processed data

---

## 📷 Sample Output

```text
======================================
 E-Commerce Order Management System
======================================

✓ Display All Orders
✓ Search Order by ID
✓ Calculate Total Sales
✓ Count Orders by Status
✓ Display Customer Orders
✓ Convert Names to Uppercase
✓ Update Pending Orders
✓ Total Orders

Program completed successfully.
```