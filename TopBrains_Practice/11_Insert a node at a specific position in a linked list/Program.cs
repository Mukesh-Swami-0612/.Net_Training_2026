using System;

public class SinglyLinkedListNode
{
    // Stores node data.
    public int data;

    // Points to the next node.
    public SinglyLinkedListNode next;

    /// <summary>
    /// Initializes a new node.
    /// </summary>
    public SinglyLinkedListNode(int nodeData)
    {
        data = nodeData;
        next = null;
    }
}

public class SinglyLinkedList
{
    // Head of the list.
    public SinglyLinkedListNode head;

    // Tail of the list.
    public SinglyLinkedListNode tail;

    /// <summary>
    /// Inserts a node at the end of the list.
    /// </summary>
    public void InsertNode(int data)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(data);

        if (head == null)
        {
            head = node;
        }
        else
        {
            tail.next = node;
        }

        tail = node;
    }

    /// <summary>
    /// Prints the linked list.
    /// </summary>
    public void Print()
    {
        SinglyLinkedListNode current = head;

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Inserts a node at the specified position.
    /// </summary>
    public void InsertAtPosition(int data, int position)
    {
        // Create the new node.
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        // Insert at the head.
        if (position == 0)
        {
            newNode.next = head;
            head = newNode;

            if (tail == null)
            {
                tail = newNode;
            }

            return;
        }

        // Traverse to the node before the position.
        SinglyLinkedListNode current = head;

        for (int i = 0; i < position - 1; i++)
        {
            current = current.next;
        }

        // Insert the new node.
        newNode.next = current.next;
        current.next = newNode;

        // Update the tail if inserted at the end.
        if (newNode.next == null)
        {
            tail = newNode;
        }
    }
}

class Program
{
    static void Main(string[] args)
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
            list.InsertNode(Convert.ToInt32(Console.ReadLine()));
        }

        // Read the new data.
        Console.Write("Enter data to insert: ");
        int data = Convert.ToInt32(Console.ReadLine());

        // Read the position.
        Console.Write("Enter position: ");
        int position = Convert.ToInt32(Console.ReadLine());

        // Insert the node.
        list.InsertAtPosition(data, position);

        // Display the updated linked list.
        Console.WriteLine("\nUpdated Linked List:");

        list.Print();
    }
}