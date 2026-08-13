# 🚛 Truck Tour (HackerRank)

A C# implementation of the **Truck Tour** problem from HackerRank. This project demonstrates how to determine the **first petrol pump** from which a truck can complete a full circular tour without running out of fuel.

> **Data Structure:** Array / List  
> **Technique Used:** Greedy Algorithm

---

## 🎯 Problem Statement

A truck must travel around a circular route of **petrol pumps**.

Each petrol pump provides a certain amount of **petrol**, and the distance to the next petrol pump requires a specific amount of fuel.

Your task is to determine the **smallest index of the petrol pump** from which the truck can complete the entire circle without running out of fuel.

Complete the following function:

```csharp
truckTour(List<List<int>> petrolpumps)
```

---

## 📥 Input Format

The first line contains an integer:

```text
n
```

where:

- **n** = Number of petrol pumps.

Each of the next **n** lines contains two space-separated integers:

```text
petrol distance
```

- `petrol` → Amount of fuel available at the current pump.
- `distance` → Fuel required to reach the next pump.

---

## 📤 Return Value

Return the **index of the first petrol pump** from which the truck can successfully complete the circular tour.

---

## ✅ Sample Input

```text
3
1 5
10 3
3 4
```

### Sample Output

```text
1
```

---

## 📌 Explanation

There are **3 petrol pumps**.

| Pump | Petrol | Distance to Next | Fuel Balance |
|------|--------:|-----------------:|-------------:|
| 0 | 1 | 5 | -4 |
| 1 | 10 | 3 | +7 |
| 2 | 3 | 4 | -1 |

Starting from **Pump 1**:

```text
Pump 1 → Pump 2 → Pump 0 → Pump 1
```

Fuel calculation:

```text
Start at Pump 1

Fuel = 10 - 3 = 7

Pump 2:
Fuel = 7 + 3 - 4 = 6

Pump 0:
Fuel = 6 + 1 - 5 = 2

Return to Pump 1 ✔
```

Therefore, the answer is:

```text
1
```

---

## 📚 Another Example

### Input

```text
4
4 6
6 5
7 3
4 5
```

### Output

```text
1
```

---

# 📝 Dry Run

Sample Input:

```text
3
1 5
10 3
3 4
```

| Pump | Petrol | Distance | Current Fuel | Action |
|------|--------:|---------:|-------------:|--------|
| 0 | 1 | 5 | -4 | Cannot start here |
| 1 | 10 | 3 | 7 | Start from here |
| 2 | 3 | 4 | 6 | Continue |
| 0 | 1 | 5 | 2 | Complete Tour ✔ |

Result:

```text
Starting Pump = 1
```

---

# ⚙️ Algorithm

1. Initialize:
   - `start = 0`
   - `fuel = 0`
   - `deficit = 0`
2. Traverse all petrol pumps.
3. For each pump:
   - Calculate:
     ```text
     fuel += petrol - distance
     ```
4. If `fuel` becomes negative:
   - Add the negative balance to `deficit`.
   - Set the next pump as the new starting point.
   - Reset `fuel` to `0`.
5. After processing all pumps:
   - If `fuel + deficit >= 0`, return `start`.
   - Otherwise, no valid starting point exists.

---

# 📊 Program Output

### Example 1

```text
Input:
3
1 5
10 3
3 4

Output:
1
```

### Example 2

```text
Input:
4
4 6
6 5
7 3
4 5

Output:
1
```

---

# 🧠 Concepts Used

- Arrays / Lists
- Greedy Algorithm
- Circular Traversal
- Running Balance
- Simulation
- Problem Optimization

---

# ⏱️ Complexity Analysis

| Operation | Complexity |
|-----------|-----------:|
| Time Complexity | **O(n)** |
| Space Complexity | **O(1)** |

Where:

- **n** = Number of petrol pumps.

The algorithm traverses the list only once, making it the optimal solution.

---

# 🎓 Learning Outcomes

This project demonstrates how to:

- Solve circular traversal problems
- Apply the Greedy Algorithm effectively
- Track cumulative fuel balance
- Identify the optimal starting point
- Optimize solutions to linear time complexity
- Solve real-world route planning and scheduling problems

---

## 📷 Sample Output

```text
Input:
3
1 5
10 3
3 4

Output:
1
```

```text
Input:
4
4 6
6 5
7 3
4 5

Output:
1
```