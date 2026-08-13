using System;
using System.Collections.Generic;

public class Playlist
{
    private readonly List<string> _songs = new();

    public void Add(string title)
    {
        _songs.Add(title);
    }

    public int Count => _songs.Count;

    public string this[int index]
    {
        get
        {
            return _songs[index];
        }
        set
        {
            _songs[index] = value;
        }
    }
}