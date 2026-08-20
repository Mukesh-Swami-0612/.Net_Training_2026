using System;
using System.Collections.Generic;

/// <summary>
/// Represents an undo system for a text editor.
/// Stack is used because the latest action must be undone first (LIFO).
/// </summary>
public class UndoManager
{
    // Stack stores the text editor actions.
    // One-line justification: Stack<T> is best because Undo follows LIFO order.
    private readonly Stack<string> _actions = new();

    /// <summary>
    /// Records a new action that can later be undone.
    /// </summary>
    public void RecordAction(string action)
    {
        // Add the latest action to the top of the stack.
        _actions.Push(action);
    }

    /// <summary>
    /// Removes and returns the most recent action.
    /// Returns null when there are no actions left.
    /// </summary>
    public string? Undo()
    {
        // Check whether the stack contains any actions.
        if (_actions.Count == 0)
        {
            return null;
        }

        // Remove and return the most recent action.
        return _actions.Pop();
    }
}