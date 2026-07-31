using System;

class DoublyNode
{
    // Stores the data value of the node.
    public int Data;

    // Stores the reference to the previous node.
    public DoublyNode? Prev;

    // Stores the reference to the next node.
    public DoublyNode? Next;

    /// <summary>
    /// Initializes a new doubly linked list node
    /// with the specified data value.
    /// </summary>
    public DoublyNode(int data)
    {
        // Assign the given value to the Data field.
        Data = data;

        // Initialize the previous node reference as null.
        Prev = null;

        // Initialize the next node reference as null.
        Next = null;
    }
}