# 📚 Course Prerequisite System

A graph-based implementation of a **University Course Prerequisite Management System** where each course is represented as a vertex and prerequisite relationships are represented as directed edges.

> **Edge Direction:**  
> `Prerequisite Course → Dependent Course`

---

## 🎯 Scenario

Design a university course system with **6 courses (0–5)** and analyze their prerequisite relationships.

### 📖 Course Dependencies

| Course | Prerequisites |
|---------|---------------|
| Course 0 | None |
| Course 1 | Course 0 |
| Course 2 | Course 0 |
| Course 3 | Course 1, Course 2 |
| Course 4 | Course 2 |
| Course 5 | Course 3, Course 4 |

---

## ✅ Tasks Performed

- Create a directed graph with **6 courses (0–5)**
- Add prerequisite relationships
- Find all **direct and indirect prerequisites** of Course 5
- Find the **direct prerequisites** of Course 3
- Detect **circular dependencies (cycles)**
- Perform **Topological Sorting**
- Identify courses with **no prerequisites**
- Count the **direct dependents** of Course 2

---

# 📊 Program Output

```
====================================
Course Prerequisite System
====================================

1. All prerequisites of Course 5
3, 1, 0, 2, 4

2. Direct prerequisites of Course 3
1, 2

3. Cycle Detection
No Cycle Found

4. Topological Sort
0 -> 1 -> 2 -> 3 -> 4 -> 5

5. Courses without prerequisites
0

6. Direct dependents of Course 2
2

====================================
```

---

## 📌 Results

### 1️⃣ All Prerequisites of Course 5
**Output:**
```
3, 1, 0, 2, 4
```

Course 5 depends on Courses **3** and **4**, which further depend on Courses **1**, **2**, and **0**.

---

### 2️⃣ Direct Prerequisites of Course 3
**Output:**
```
1, 2
```

Course 3 can only be taken after completing Courses **1** and **2**.

---

### 3️⃣ Cycle Detection
**Output:**
```
No Cycle Found
```

The prerequisite graph is **acyclic**, meaning there are no circular dependencies.

---

### 4️⃣ Topological Sort
**Output:**
```
0 → 1 → 2 → 3 → 4 → 5
```

A valid order in which a student can complete all courses while satisfying prerequisites.

---

### 5️⃣ Courses Without Prerequisites
**Output:**
```
0
```

Course **0** can be taken immediately since it has no prerequisite.

---

### 6️⃣ Direct Dependents of Course 2
**Output:**
```
2
```

Course **2** is a direct prerequisite for:
- Course 3
- Course 4

Total Direct Dependents: **2**

---

# 🧠 Graph Concepts Used

- Directed Graph
- Adjacency List
- Depth-First Search (DFS)
- Cycle Detection
- Topological Sorting
- Graph Traversal
- Dependency Analysis

---

## 🎓 Learning Outcomes

This project demonstrates how graph algorithms can be used to model real-world course dependency systems by:

- Managing prerequisite relationships
- Detecting invalid circular dependencies
- Finding prerequisite chains
- Generating valid course completion order
- Analyzing dependency relationships efficiently

---

## 📷 Sample Output

```
====================================
Course Prerequisite System
====================================

✓ All prerequisites of Course 5
✓ Direct prerequisites of Course 3
✓ Cycle Detection
✓ Topological Sort
✓ Courses without prerequisites
✓ Direct dependents of Course 2

====================================
```