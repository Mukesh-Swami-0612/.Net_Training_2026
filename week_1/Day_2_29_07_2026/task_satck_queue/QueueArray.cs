using System;

class QueueArray
{
    // Array used to store queue elements.
    int[] queue = new int[5];

    // Points to the first element in the queue.
    int front = 0;

    // Points to the last element in the queue.
    int rear = -1;

    /// <summary>
    /// Adds a new element to the rear of the queue.
    /// </summary>
    public void Enqueue(int value)
    {
        // Check if the queue is full.
        if (rear == queue.Length - 1)
        {
            Console.WriteLine("Queue Full");
            return;
        }

        // Insert the new element and move the rear pointer.
        queue[++rear] = value;
    }

    /// <summary>
    /// Removes the front element from the queue.
    /// </summary>
    public void Dequeue()
    {
        // Check if the queue is empty.
        if (front > rear)
        {
            Console.WriteLine("Queue Empty");
            return;
        }

        // Display and remove the front element.
        Console.WriteLine("Deleted: " + queue[front++]);
    }

    /// <summary>
    /// Displays all elements currently present in the queue.
    /// </summary>
    public void Display()
    {
        // Check if the queue is empty.
        if (front > rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        // Display the queue heading.
        Console.WriteLine("Queue Elements:");

        // Traverse and display all queue elements.
        for (int i = front; i <= rear; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
}