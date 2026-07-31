using System;

class Program
{
    /// <summary>
    /// Entry point of the Stack and Queue application.
    /// Demonstrates basic stack operations (Push, Pop, Display)
    /// and queue operations (Enqueue, Dequeue, Display).
    /// </summary>
    static void Main()
    {
        // Demonstrate Stack operations.
        Console.WriteLine("Stack");

        // Create an object of the StackArray class.
        StackArray s = new StackArray();

        // Push elements onto the stack.
        s.Push(10);
        s.Push(20);
        s.Push(30);

        // Display all stack elements.
        s.Display();

        // Remove the top element from the stack.
        s.Pop();

        // Display the stack after the pop operation.
        Console.WriteLine("After Pop:");
        s.Display();

        // Demonstrate Queue operations.
        Console.WriteLine("\nQueue");

        // Create an object of the QueueArray class.
        QueueArray q = new QueueArray();

        // Add elements to the queue.
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        // Display all queue elements.
        q.Display();

        // Remove the front element from the queue.
        q.Dequeue();

        // Display the queue after the dequeue operation.
        Console.WriteLine("After Dequeue:");
        q.Display();
    }
}