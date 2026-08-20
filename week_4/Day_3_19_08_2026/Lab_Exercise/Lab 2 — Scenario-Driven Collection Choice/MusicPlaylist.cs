using System;
using System.Collections.Generic;

/// <summary>
/// Represents a music playlist where songs can be inserted or removed.
/// LinkedList is used for efficient insertion and removal of nodes.
/// </summary>
public class MusicPlaylist
{
    // LinkedList stores songs in playlist order.
    // One-line justification: LinkedList<T> is suitable for efficient insertion/removal at a known node.
    private readonly LinkedList<string> _songs = new();

    /// <summary>
    /// Inserts a new song after the specified existing song.
    /// </summary>
    public void InsertAfter(string afterSong, string newSong)
    {
        // Find the song after which the new song should be inserted.
        LinkedListNode<string>? node = _songs.Find(afterSong);

        // If the song exists, insert the new song after it.
        if (node != null)
        {
            _songs.AddAfter(node, newSong);
        }
    }

    /// <summary>
    /// Removes the specified song from the playlist.
    /// </summary>
    public void Remove(string song)
    {
        // Find the song in the playlist.
        LinkedListNode<string>? node = _songs.Find(song);

        // Remove the song if it exists.
        if (node != null)
        {
            _songs.Remove(node);
        }
    }

    /// <summary>
    /// Adds a song to the end of the playlist.
    /// </summary>
    public void Add(string song)
    {
        // Add the song to the end of the playlist.
        _songs.AddLast(song);
    }

    /// <summary>
    /// Displays all songs in the playlist.
    /// </summary>
    public void Display()
    {
        // Print the songs in their current playlist order.
        Console.WriteLine(string.Join(" -> ", _songs));
    }
}