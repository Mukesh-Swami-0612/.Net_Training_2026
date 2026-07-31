Arrays - DS (HackerRank)

Problem Statement



An array is a data structure that stores elements of the same type in contiguous memory.



Given an array of integers, your task is to reverse the elements of the array and return the reversed array.



Complete the function reverseArray that takes an integer array as input and returns the array in reverse order.



Function Description



Complete the following function:



reverseArray(List<int> a)

Parameter

a : A list of integers.

Return

A list of integers containing the elements of the original array in reverse order.

Input Format

The first line contains an integer n, representing the number of elements in the array.

The second line contains n space-separated integers.

Constraints

1 ≤ n ≤ 1000

1 ≤ a[i] ≤ 10000

Sample Input

4

1 4 3 2

Expected Output

2 3 4 1

Explanation



Original Array:



1 4 3 2



After reversing:



2 3 4 1

Another Example

Input

5

10 20 30 40 50

Expected Output

50 40 30 20 10

Dry Run

Step	Left	Right	Array

Initial	0	3	1 4 3 2

Swap 1 & 2	1	2	2 4 3 1

Swap 4 & 3	2	1	2 3 4 1

Stop	Left ≥ Right		2 3 4 1

Algorithm

Initialize two pointers:

left = 0

right = n - 1

Swap the elements at left and right.

Increment left and decrement right.

Repeat until left becomes greater than or equal to right.

Return the reversed array.

Time Complexity

O(n)

Space Complexity

O(1) (In-place reversal)



This is the optimal approach because it reverses the array without using any extra data structure or built-in reverse function.