using System;

public class SinglyLinkedListNode
{
    // Stores the node data.
    public int data;

    // Reference to the next node.
    public SinglyLinkedListNode next;

    /// <summary>
    /// Initializes a new node.
    /// </summary>
    public SinglyLinkedListNode(int value)
    {
        data = value;
        next = null;
    }
}

public class SinglyLinkedList
{
    // Head of the linked list.
    public SinglyLinkedListNode head;

    /// <summary>
    /// Inserts a node at the head of the linked list.
    /// </summary>
    public void InsertAtHead(int data)
    {
        // Create a new node.
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        // Point the new node to the current head.
        newNode.next = head;

        // Update the head.
        head = newNode;
    }

    /// <summary>
    /// Displays the linked list.
    /// </summary>
    public void Display()
    {
        // Start from the head.
        SinglyLinkedListNode current = head;

        // Traverse the linked list.
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create a linked list.
        SinglyLinkedList list = new SinglyLinkedList();

        // Read the number of nodes.
        Console.Write("Enter number of nodes: ");
        int n = Convert.ToInt32(Console.ReadLine()!);

        // Read the node values.
        Console.WriteLine("Enter node values:");

        for (int i = 0; i < n; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine()!);

            // Insert each node at the head.
            list.InsertAtHead(value);
        }

        // Display the updated linked list.
        Console.WriteLine("\nLinked List:");

        list.Display();
    }
}