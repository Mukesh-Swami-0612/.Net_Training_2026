using System;

class DoublyLinkedList
{
    // Stores the reference to the first node of the doubly linked list.
    private DoublyNode? head = null;

    /// <summary>
    /// Inserts a new node at the end of the doubly linked list.
    /// </summary>
    public void Insert(int data)
    {
        // Create a new node with the given data.
        DoublyNode newNode = new DoublyNode(data);

        // Check if the linked list is empty.
        if (head == null)
        {
            // Make the new node the head node.
            head = newNode;
            return;
        }

        // Start traversal from the head node.
        DoublyNode temp = head;

        // Traverse until the last node is reached.
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        // Link the last node to the new node.
        temp.Next = newNode;

        // Link the new node back to the previous node.
        newNode.Prev = temp;
    }

    /// <summary>
    /// Displays all nodes of the doubly linked list
    /// in forward direction.
    /// </summary>
    public void DisplayForward()
    {
        // Start traversal from the head node.
        DoublyNode? temp = head;

        // Traverse and display each node.
        while (temp != null)
        {
            Console.Write(temp.Data + " <-> ");
            temp = temp.Next;
        }

        // Display the end of the linked list.
        Console.WriteLine("NULL");
    }
}