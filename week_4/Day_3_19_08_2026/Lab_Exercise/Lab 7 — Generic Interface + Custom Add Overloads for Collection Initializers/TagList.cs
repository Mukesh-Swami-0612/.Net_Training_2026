using System.Collections;
using System.Collections.Generic;

namespace Lab7;

// Custom collection of tags that supports foreach and collection initializers.
public class TagList : IEnumerable<string>
{
    // Stores the tag objects internally.
    private readonly List<TagItem> _items = new();

    // Adds a normal tag.
    public void Add(string tag)
    {
        _items.Add(new TagItem(tag, false));
    }

    // Adds a tag with a highlighted value.
    public void Add(string tag, bool highlighted)
    {
        _items.Add(new TagItem(tag, highlighted));
    }

    // Allows foreach to iterate through the tag names.
    public IEnumerator<string> GetEnumerator()
    {
        foreach (var item in _items)
        {
            yield return item.Tag;
        }
    }

    // Provides the non-generic enumerator required by IEnumerable.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Displays the complete tag information.
    public void PrintDetails()
    {
        foreach (var item in _items)
        {
            System.Console.WriteLine(item);
        }
    }
}