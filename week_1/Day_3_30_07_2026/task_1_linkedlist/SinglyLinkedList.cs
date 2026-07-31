using System;

class SinglyLinkedList
{
    // Stores the reference to the first node of the linked list.
    private SinglyNode? head = null;

    /// <summary>
    /// Inserts a new node at the end of the singly linked list.
    /// </summary>
    public void Insert(int data)
    {
        // Create a new node with the given data.
        SinglyNode newNode = new SinglyNode(data);

        // Check if the linked list is empty.
        if (head == null)
        {
            // Make the new node the head node.
            head = newNode;
            return;
        }

        // Start traversal from the head node.
        SinglyNode temp = head;

        // Traverse until the last node is reached.
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        // Link the last node to the new node.
        temp.Next = newNode;
    }

    /// <summary>
    /// Displays all nodes of the singly linked list.
    /// </summary>
    public void Display()
    {
        // Start traversal from the head node.
        SinglyNode? temp = head;

        // Traverse and display each node.
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }

        // Display the end of the linked list.
        Console.WriteLine("NULL");
    }
}