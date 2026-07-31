using System;

class CircularLinkedList
{
    // Stores the reference to the first node of the circular linked list.
    private CircularNode? head = null;

    /// <summary>
    /// Inserts a new node at the end of the circular linked list.
    /// </summary>
    public void Insert(int data)
    {
        // Create a new node with the given data.
        CircularNode newNode = new CircularNode(data);

        // Check if the linked list is empty.
        if (head == null)
        {
            // Make the new node the head node.
            head = newNode;

            // Point the node to itself to form a circular link.
            newNode.Next = head;
            return;
        }

        // Start traversal from the head node.
        CircularNode temp = head;

        // Traverse until the last node is reached.
        while (temp.Next != head)
        {
            temp = temp.Next!;
        }

        // Link the last node to the new node.
        temp.Next = newNode;

        // Make the new node point back to the head node.
        newNode.Next = head;
    }

    /// <summary>
    /// Displays all nodes of the circular linked list.
    /// </summary>
    public void Display()
    {
        // Check if the linked list is empty.
        if (head == null)
            return;

        // Start traversal from the head node.
        CircularNode temp = head;

        // Traverse and display each node until the head is reached again.
        do
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next!;
        }
        while (temp != head);

        // Indicate that the list loops back to the head node.
        Console.WriteLine("(Back to Head)");
    }
}