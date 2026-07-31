# 👥 Social Network Friend Recommendations

A graph-based implementation of a **Social Network Friend Recommendation System** where users are represented as vertices and friendships are represented as undirected edges.

> **Graph Type:** Undirected & Unweighted Graph  
> **Friendships are mutual** (if User A is friends with User B, then User B is also friends with User A).

---

## 🎯 Scenario

Build a simple social network containing **6 users (0–5)** and perform various graph operations to analyze friendships and network connectivity.

---

## 🤝 Friendship Network

| User | Friends |
|------|----------|
| User 0 | 1, 2 |
| User 1 | 0, 3 |
| User 2 | 0, 3, 4 |
| User 3 | 1, 2, 5 |
| User 4 | 2, 5 |
| User 5 | 3, 4 |

---

## ✅ Tasks Performed

- Create an undirected graph with **6 users (0–5)**
- Add friendship relationships
- Find all friends of User 2
- Check whether User 0 and User 5 are connected
- Find the shortest friendship path between User 0 and User 5
- Find all users at **distance 2** from User 1
- Detect cycles in the friendship network
- Find all connected components (friend groups)

---

# 📊 Program Output

```text
==========================================
 Social Network Friend Recommendation
==========================================

Friends of User 2:
0 3 4

Are User 0 and User 5 Connected?
Yes

Shortest Path (0 → 5):
0 -> 2 -> 3 -> 5

Users at Distance 2 from User 1:
2 5

Cycle Present?
Yes

Connected Components:
Component 1: 0 1 3 2 4 5

Program Executed Successfully.
```

---

## 📌 Results

### 1️⃣ Friends of User 2

**Output:**
```text
0 3 4
```

User **2** is directly connected with:

- User 0
- User 3
- User 4

---

### 2️⃣ Connectivity Check

**Output:**
```text
Yes
```

User **0** and User **5** are connected through intermediate friendships, meaning they belong to the same connected network.

---

### 3️⃣ Shortest Friendship Path

**Output:**
```text
0 -> 2 -> 3 -> 5
```

The shortest chain of friendships from **User 0** to **User 5** consists of **3 connections**.

---

### 4️⃣ Users at Distance 2 from User 1

**Output:**
```text
2 5
```

These users are not direct friends of User **1**, but can be reached through exactly one mutual friend.

---

### 5️⃣ Cycle Detection

**Output:**
```text
Yes
```

The social network contains one or more friendship cycles, indicating multiple routes exist between certain users.

---

### 6️⃣ Connected Components

**Output:**
```text
Component 1: 0 1 3 2 4 5
```

All six users belong to a **single connected component**, meaning every user can reach every other user through friendships.

---

# 🧠 Graph Concepts Used

- Undirected Graph
- Adjacency List
- Breadth-First Search (BFS)
- Depth-First Search (DFS)
- Shortest Path (Unweighted Graph)
- Cycle Detection
- Connected Components
- Graph Traversal

---

## 🎓 Learning Outcomes

This project demonstrates how graph algorithms can model and analyze real-world social networks by:

- Managing friendship relationships
- Finding mutual connections
- Checking user connectivity
- Discovering shortest friendship paths
- Detecting cycles in the network
- Identifying friend groups (connected components)

---

## 📷 Sample Output

```text
==========================================
 Social Network Friend Recommendation
==========================================

✓ Friends of User 2
✓ Connectivity Check
✓ Shortest Friendship Path
✓ Users at Distance 2
✓ Cycle Detection
✓ Connected Components

Program Executed Successfully.
```