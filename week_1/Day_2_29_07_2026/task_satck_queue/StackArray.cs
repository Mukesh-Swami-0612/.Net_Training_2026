using System;

class StackArray
{
    // Array used to store stack elements.
    int[] stack = new int[5];

    // Points to the top element of the stack.
    int top = -1;

    /// <summary>
    /// Adds a new element to the top of the stack.
    /// </summary>
    public void Push(int value)
    {
        // Check if the stack is full.
        if (top == stack.Length - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        // Insert the new element and move the top pointer.
        stack[++top] = value;
    }

    /// <summary>
    /// Removes the top element from the stack.
    /// </summary>
    public void Pop()
    {
        // Check if the stack is empty.
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

        // Display and remove the top element.
        Console.WriteLine("Deleted: " + stack[top--]);
    }

    /// <summary>
    /// Displays all elements currently present in the stack.
    /// </summary>
    public void Display()
    {
        // Check if the stack is empty.
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }

        // Display the stack heading.
        Console.WriteLine("Stack Elements:");

        // Traverse and display stack elements from top to bottom.
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stack[i]);
        }
    }
}