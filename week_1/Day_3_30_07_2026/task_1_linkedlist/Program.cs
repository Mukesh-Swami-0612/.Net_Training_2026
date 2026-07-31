using System;

class Program
{
    /// <summary>
    /// Entry point of the Linked List application.
    /// Demonstrates the implementation of Singly,
    /// Doubly, and Circular Linked Lists.
    /// </summary>
    static void Main(string[] args)
    {
        // Demonstrate Singly Linked List operations.
        // Console.WriteLine("Singly Linked List");

        // Create an object of the SinglyLinkedList class.
        // SinglyLinkedList sll = new SinglyLinkedList();

        // Insert nodes into the singly linked list.
        // sll.Insert(10);
        // sll.Insert(20);
        // sll.Insert(30);
        // sll.Insert(40);

        // Display the singly linked list.
        // sll.Display();

        // Console.WriteLine();

        // Demonstrate Doubly Linked List operations.
        // Console.WriteLine("Doubly Linked List");

        // Create an object of the DoublyLinkedList class.
        // DoublyLinkedList dll = new DoublyLinkedList();

        // Insert nodes into the doubly linked list.
        // dll.Insert(100);
        // dll.Insert(200);
        // dll.Insert(300);
        // dll.Insert(400);

        // Display the doubly linked list.
        // dll.DisplayForward();

        // Console.WriteLine();

        // Demonstrate Circular Linked List operations.
        Console.WriteLine("Circular Linked List");

        // Create an object of the CircularLinkedList class.
        CircularLinkedList cll = new CircularLinkedList();

        // Insert nodes into the circular linked list.
        cll.Insert(10);
        cll.Insert(20);
        cll.Insert(30);
        cll.Insert(40);

        // Display the circular linked list.
        cll.Display();
    }
}