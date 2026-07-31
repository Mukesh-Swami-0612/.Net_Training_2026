2D Array - DS (HackerRank)
Problem Statement

Given a 6 × 6 two-dimensional array of integers, an hourglass is a subset of values with indices arranged in the following pattern:

a b c
  d
e f g

Your task is to calculate the sum of every possible hourglass in the 6 × 6 array and return the maximum hourglass sum.

There are 16 possible hourglasses in a 6 × 6 array.

Function Description

Complete the function:

hourglassSum(List<List<int>> arr)
Parameter
arr : A 6 × 6 two-dimensional integer array.
Return
An integer representing the maximum hourglass sum.
Input Format
The input consists of 6 lines.
Each line contains 6 space-separated integers.
Constraints
The array size is always 6 × 6.
Array elements range from -9 to 9.
Sample Input
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
Expected Output
19
Explanation

The maximum hourglass is:

2 4 4
  2
1 2 4

Hourglass Sum

2 + 4 + 4 + 2 + 1 + 2 + 4 = 19
Another Example
Input
-9 -9 -9 1 1 1
0 -9 0 4 3 2
-9 -9 -9 1 2 3
0 0 8 6 6 0
0 0 0 -2 0 0
0 0 1 2 4 0
Expected Output
28