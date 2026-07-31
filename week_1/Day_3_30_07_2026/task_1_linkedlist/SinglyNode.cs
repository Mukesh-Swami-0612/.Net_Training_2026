using System;

class SinglyNode
{
    // Stores the data value of the node.
    public int Data;

    // Stores the reference to the next node in the linked list.
    public SinglyNode? Next;

    /// <summary>
    /// Initializes a new singly linked list node
    /// with the specified data value.
    /// </summary>
    public SinglyNode(int data)
    {
        // Assign the given value to the Data field.
        Data = data;

        // Initialize the Next reference as null.
        Next = null;
    }
}