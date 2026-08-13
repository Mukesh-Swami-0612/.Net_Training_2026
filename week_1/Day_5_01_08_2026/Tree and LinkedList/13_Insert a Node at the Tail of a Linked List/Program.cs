using System;

public class SinglyLinkedListNode
{
    // Stores the node value.
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
    /// Inserts a node at the tail.
    /// </summary>
    public void InsertAtTail(int data)
    {
        // Create the new node.
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        // If the list is empty.
        if (head == null)
        {
            head = newNode;
            return;
        }

        // Traverse to the last node.
        SinglyLinkedListNode current = head;

        while (current.next != null)
        {
            current = current.next;
        }

        // Add the node.
        current.next = newNode;
    }

    /// <summary>
    /// Prints the linked list.
    /// </summary>
    public void Display()
    {
        SinglyLinkedListNode current = head;

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
        int n = Convert.ToInt32(Console.ReadLine());

        // Read node values.
        Console.WriteLine("Enter node values:");

        for (int i = 0; i < n; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            list.InsertAtTail(value);
        }

        Console.WriteLine("\nLinked List:");

        list.Display();
    }
}